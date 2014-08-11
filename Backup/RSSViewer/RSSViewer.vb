Public Class RSSViewer

  Private feedItems As ArrayList

  Private Sub lbItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbItems.SelectedIndexChanged
    If lbItems.Items.Count > 0 Then
      Dim currentItem As RSSItem

      currentItem = feedItems(lbItems.SelectedIndex)
      WebBrowser1.DocumentText = currentItem.Description
      linkItemURL.Text = currentItem.Link
      linkItemURL.Links(0).Start = 0
      linkItemURL.Links(0).Length = currentItem.Link.Length
      linkItemURL.Links(0).LinkData = currentItem.Link
    End If
  End Sub

  Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    RefreshChannel()
  End Sub

  Private Sub RSSViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    tbChannel.Text = "http://www.developer.com/icom_includes/feeds/special/dev-5.xml"
    lblTitle.Text = ""
    lblDescription.Text = ""
    linkChannel.Text = ""
    linkChannel.Links.Add(0, 1, "")
    linkItemURL.Text = ""
    linkItemURL.Links.Add(0, 1, "")

    RefreshChannel()
  End Sub

  Private Sub linkItemURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkItemURL.LinkClicked
    System.Diagnostics.Process.Start(linkItemURL.Links(0).LinkData)
  End Sub

  Private Sub linkChannel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkChannel.LinkClicked
    System.Diagnostics.Process.Start(linkChannel.Links(0).LinkData)
  End Sub

  Private Sub RefreshChannel()
    If tbChannel.Text <> "" Then
      Dim channel As New RSSChannel(tbChannel.Text)

      lblTitle.Text = channel.Title
      lblDescription.Text = channel.Description
      linkChannel.Text = channel.Link
      linkChannel.Links(0).Start = 0
      linkChannel.Links(0).Length = channel.Link.Length
      linkChannel.Links(0).LinkData = channel.Link

      feedItems = channel.GetChannelItems()
      lbItems.DisplayMember = "Title"
      lbItems.ValueMember = "Title"
      lbItems.DataSource = feedItems
    End If
  End Sub
End Class