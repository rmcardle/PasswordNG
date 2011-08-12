Public Class PassPhrase
#Region "Properties"
    Dim _numberOfWords As Integer
    Public Property NumberOfWords() As Integer
        Get
            Return _numberOfWords
        End Get
        Set(ByVal value As Integer)
            _numberOfWords = value
        End Set
    End Property

    Dim _minWordLength As Integer
    Public Property MinWordLength() As Integer
        Get
            Return _minWordLength
        End Get
        Set(ByVal value As Integer)
            _minWordLength = value
        End Set
    End Property

    Dim _maxWordLength As Integer
    Public Property MaxWordLength() As Integer
        Get
            Return _maxWordLength
        End Get
        Set(ByVal value As Integer)
            _maxWordLength = value
        End Set
    End Property

    Dim _words As WordList
    Protected ReadOnly Property Words() As WordList
        Get
            If _words Is Nothing Then _words = New WordList("C:\Users\Riley\Documents\Visual Studio 2008\Projects\PasswordNG\PasswordNG\Word Lists\English.txt")
            Return _words
        End Get
    End Property

    Dim _badWords As WordList
    Protected ReadOnly Property BadWords() As WordList
        Get
            If _badWords Is Nothing Then _badWords = New WordList("C:\Users\Riley\Documents\Visual Studio 2008\Projects\PasswordNG\PasswordNG\Word Lists\Bad Words.txt")
            Return _badWords
        End Get
    End Property
#End Region

#Region "Constructors/Destructors"
    Sub New(Optional ByVal numberOfWords As Integer = 4, Optional ByVal minWordLength As Integer = 0, Optional ByVal maxWordLength As Integer = 0)
        Me.NumberOfWords = numberOfWords
        Me.MinWordLength = minWordLength
        Me.MaxWordLength = maxWordLength
    End Sub
#End Region

#Region "Public Methods"
    Public Function Generate() As String
        Dim words As New List(Of String)
        For x As Integer = 1 To Me.NumberOfWords
            words.Add(GetWord())
        Next
        Return String.Join(" ", words)
    End Function
#End Region

#Region "Protected Methods"
    Protected Function GetWord()
        Dim word As String
        Do
            word = Me.Words.GetRandom(Me.MinWordLength, Me.MaxWordLength)
        Loop Until Not Me.BadWords.IsInList(word)
        Return word
    End Function
#End Region
End Class
