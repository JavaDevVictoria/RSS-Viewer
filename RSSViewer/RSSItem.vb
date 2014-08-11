Public Class RSSItem
  Private m_Title As String
  Private m_Link As String
  Private m_Description As String

#Region "Properties"
  Public Property Title() As String
    Get
      Return m_Title
    End Get
    Set(ByVal value As String)
      m_Title = value
    End Set
  End Property

  Public Property Link() As String
    Get
      Return m_Link
    End Get
    Set(ByVal value As String)
      m_Link = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Return m_Description
    End Get
    Set(ByVal value As String)
      m_Description = value
    End Set
  End Property
#End Region

  Public Sub New()
    Title = ""
    Link = ""
    Description = ""
  End Sub
End Class