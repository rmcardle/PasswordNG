Imports System.IO

Public Class WordList
#Region "Properties"
    Protected _fileName As String
    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
            Me.Words.Clear()
        End Set
    End Property

    Protected _words As New List(Of String)
    Public ReadOnly Property Words() As List(Of String)
        Get
            If Not _words.Count And FileName IsNot Nothing Then
                Me.Load()
            End If
            Return _words
        End Get
    End Property
#End Region

#Region "Constructors/Destructors"
    Sub New(Optional ByVal fileName As String = Nothing)
        Me.FileName = fileName
    End Sub
#End Region

#Region "Public Methods"
    Public Function GetRandom(Optional ByVal minLength As Integer = 0, Optional ByVal maxLength As Integer = 0) As String
        If maxLength = 1 Then Throw New ArgumentException("maxLength cannot be 1")
        If maxLength > 1 And minLength > maxLength Then Throw New ArgumentException("minLength cannot be greater than maxLength")
        Dim word As String = Nothing
        Dim found As String = Nothing
        Dim index As Integer
        Do
            index = CInt(Rnd() * Me.Words.Count)
            found = Me.Words(index)
            If IsValidWord(found, minLength, maxLength) Then
                word = found
            End If
        Loop Until word IsNot Nothing
        Return word
    End Function

    Public Function IsInList(ByVal word As String) As Boolean
        Return Me.Words.Contains(word)
    End Function
#End Region

#Region "Protected Methods"
    Protected Sub Load()
        _words.Clear()
        Dim file As StreamReader = Nothing
        Try
            file = New StreamReader(Me.FileName)
            Dim line As String
            Do
                line = file.ReadLine()
                If line IsNot Nothing Then _words.Add(line)
            Loop Until line Is Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            If file IsNot Nothing Then file.Close()
        End Try
    End Sub

    Protected Function IsValidWord(word As String, Optional ByVal minLength As Integer = 0, Optional ByVal maxLength As Integer = 0) As Boolean
        If word.Length < minLength Or (maxLength > 1 And word.Length > maxLength) Then Return False
        If Not word = word.ToLower Then Return False
        Dim badCharacters As String = " -':."
        For Each character As String In badCharacters
            If InStr(word, character) Then Return False
        Next
        Return True
    End Function
#End Region
End Class
