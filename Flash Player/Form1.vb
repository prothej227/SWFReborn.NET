Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load event during form load
    End Sub

    Private Sub OpenSWFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSWFToolStripMenuItem.Click

        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Filter = "Shockwave Flash Object|*.swf|All Files|*.*"
            .FilterIndex = 1
        End With

        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Me.Text = "SWF Reborn v1.0 | Playing: " + System.IO.Path.GetFileName(OpenFileDialog1.FileName)

            Label1.Hide()
            Load_Flash(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub Load_Flash(ByVal fileName As String)
        AxShockwaveFlash1.ScaleMode = 0
        AxShockwaveFlash1.Movie = fileName
        AxShockwaveFlash1.Visible = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AxShockwaveFlash1.ScaleMode = 0
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        AxShockwaveFlash1.ScaleMode = 1
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        AxShockwaveFlash1.ScaleMode = 2
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        AxShockwaveFlash1.LoadMovie(0, vbNull)
        AxShockwaveFlash1.Hide()
        Me.Text = "SWF Reborn v1.00"
        Label1.Show()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxShockwaveFlash1.AllowFullScreen = "true"
    End Sub

    Private Sub HighToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighToolStripMenuItem.Click
        HighToolStripMenuItem.Checked = True
        LowToolStripMenuItem.Checked = False
        AutoModeToolStripMenuItem.Checked = False
        AxShockwaveFlash1.Quality = 1
    End Sub

    Private Sub LowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowToolStripMenuItem.Click
        HighToolStripMenuItem.Checked = False
        LowToolStripMenuItem.Checked = True
        AutoModeToolStripMenuItem.Checked = False
        AxShockwaveFlash1.Quality = 0
    End Sub

    Private Sub AutoModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoModeToolStripMenuItem.Click
        HighToolStripMenuItem.Checked = False
        LowToolStripMenuItem.Checked = False
        AutoModeToolStripMenuItem.Checked = True
        AxShockwaveFlash1.Quality = 2

    End Sub

    Private Sub QualityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QualityToolStripMenuItem.Click

    End Sub
End Class


