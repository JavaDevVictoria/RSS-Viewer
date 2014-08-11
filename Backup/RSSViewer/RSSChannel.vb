Imports System.IO
Imports System.Net
Imports System.Xml

Public Class RSSChannel
  Private m_FeedURL As String
  Private m_Title As String
  Private m_Link As String
  Private m_Description As String

#Region "Properties"
  Public Property FeedURL() As String
    Get
      Return m_FeedURL
    End Get
    Set(ByVal value As String)
      m_FeedURL = value
    End Set
  End Property
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

#Region "Methods"
  Public Sub New(ByVal url As String)
    FeedURL = url
    Title = ""
    Link = ""
    Description = ""
    GetChannelInfo()
  End Sub

  Private Function GetXMLDoc(ByVal node As String) As XmlNodeList
    Dim tempNodeList As System.Xml.XmlNodeList = Nothing

    Dim request As WebRequest = WebRequest.Create(Me.FeedURL)
    Dim response As WebResponse = request.GetResponse()
    Dim rssStream As Stream = response.GetResponseStream()
    Dim rssDoc As XmlDocument = New XmlDocument()
    rssDoc.Load(rssStream)
    tempNodeList = rssDoc.SelectNodes(node)

    Return tempNodeList
  End Function

  Private Sub GetChannelInfo()
    Dim rss As XmlNodeList = GetXMLDoc("rss/channel")
    Title = rss(0).SelectSingleNode("title").InnerText
    Link = rss(0).SelectSingleNode("link").InnerText
    Description = rss(0).SelectSingleNode("description").InnerText
  End Sub

  Public Function GetChannelItems() As ArrayList
    Dim tempArrayList As New ArrayList

    Dim rssItems As XmlNodeList = GetXMLDoc("rss/channel/item")
    Dim item As XmlNode
    For Each item In rssItems
      Dim newItem As New RSSItem
      With newItem
        .Title = item.SelectSingleNode("title").InnerText
        .Link = item.SelectSingleNode("link").InnerText
        .Description = item.SelectSingleNode("description").InnerText
      End With
      tempArrayList.Add(newItem)
    Next

    Return tempArrayList
  End Function
#End Region
End Class