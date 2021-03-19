'Initial code credited to:
'Nosware
'following tutorial at:
'https://www.youtube.com/watch?v=UQKhHKNmp8g&t=28s

Public Class frmSlots

    Dim intM, intA, intB, intC, intD, intE, intF, intMultiplier As Integer
    Dim intBal As Integer = 50

    Private Sub frmSlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        MenuStrip1.ForeColor = Color.White
        nudLabel.AutoSize = False
        nudLabel.Location = nudBet.Location
        nudLabel.BorderStyle = nudBet.BorderStyle
        nudBet.BorderStyle = BorderStyle.None
        nudBet.Controls.RemoveAt(0)
        nudBet.Parent = nudLabel
        nudBet.Location = Point.Empty
        nudLabel.ClientSize = nudBet.Size
        nudLabel.Width -= 25
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        nudBet.Value = 1
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        nudBet.Value = 3
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim file As System.IO.StreamWriter
        My.Computer.FileSystem.CreateDirectory("Save")
        file = My.Computer.FileSystem.OpenTextFileWriter("Save\SpinToWin.sav", False)
        file.WriteLine(intBal.ToString)
        file.Close()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("Save\SpinToWin.sav")
        intBal = Convert.ToInt32(fileReader.Trim)
        lblBalance.Text = fileReader.Trim
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        intBal = 50
        lblBalance.Text = "50"
        btnSpin.Enabled = True
        lblDeclaration.Text = "        Spin and Win....Again!"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intM += 20
        If intM < 500 Then
            intA = Int((6 * Rnd()) + 1)
            Select Case intA
                Case 1
                    picReel1.Image = My.Resources.slot1
                Case 2
                    picReel1.Image = My.Resources.slot2
                Case 3
                    picReel1.Image = My.Resources.slot3
                Case 4
                    picReel1.Image = My.Resources.slot4
                Case 5
                    picReel1.Image = My.Resources.slot5
                Case 6
                    picReel1.Image = My.Resources.slot6
            End Select
        End If

        If intM < 700 Then
            intB = Int((6 * Rnd()) + 1)
            Select Case intB
                Case 1
                    picReel2.Image = My.Resources.slot1
                Case 2
                    picReel2.Image = My.Resources.slot2
                Case 3
                    picReel2.Image = My.Resources.slot3
                Case 4
                    picReel2.Image = My.Resources.slot4
                Case 5
                    picReel2.Image = My.Resources.slot5
                Case 6
                    picReel2.Image = My.Resources.slot6
            End Select
        End If

        If intM < 900 Then
            intC = Int((6 * Rnd()) + 1)
            Select Case intC
                Case 1
                    picReel3.Image = My.Resources.slot1
                Case 2
                    picReel3.Image = My.Resources.slot2
                Case 3
                    picReel3.Image = My.Resources.slot3
                Case 4
                    picReel3.Image = My.Resources.slot4
                Case 5
                    picReel3.Image = My.Resources.slot5
                Case 6
                    picReel3.Image = My.Resources.slot6
            End Select
        Else
            EndSpin()
        End If



    End Sub

    Private Sub EndSpin()
        Timer1.Enabled = False
        intM = 0
        Winnings()
    End Sub

    Private Sub Winnings()
        If intA = 6 And intB = 6 And intC = 6 Then
            lblDeclaration.Text = ("        You won $") & (100 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.jackpot, AudioPlayMode.Background)
            BalUpdate(100 * intMultiplier)
        ElseIf intA = 5 And intB = 5 And intC = 5 Then
            lblDeclaration.Text = ("        You won $") & (47 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(47 * intMultiplier)
        ElseIf intA = 4 And intB = 4 And intC = 4 Then
            lblDeclaration.Text = ("        You won $") & (23 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(23 * intMultiplier)
        ElseIf intA = 4 And intB = 4 And intC = 5 Then
            lblDeclaration.Text = ("        You won $") & (23 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(23 * intMultiplier)
        ElseIf intA = 3 And intB = 3 And intC = 3 Then
            lblDeclaration.Text = ("        You won $") & (17 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(17 * intMultiplier)
        ElseIf intA = 3 And intB = 3 And intC = 5 Then
            lblDeclaration.Text = ("        You won $") & (17 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(17 * intMultiplier)
        ElseIf intA = 2 And intB = 2 And intC = 2 Then
            lblDeclaration.Text = ("        You won $") & (13 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(13 * intMultiplier)
        ElseIf intA = 2 And intB = 2 And intC = 5 Then
            lblDeclaration.Text = ("        You won $") & (7 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(7 * intMultiplier)
        ElseIf intA = 1 And intB = 1 And intC = 1 Then
            lblDeclaration.Text = ("        You won $") & (7 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(7 * intMultiplier)
        ElseIf intA = 1 And intB = 1 Then
            lblDeclaration.Text = ("        You won $") & (3 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(3 * intMultiplier)
        ElseIf intA = 1 Then
            lblDeclaration.Text = ("        You won $") & (1 * intMultiplier).ToString
            My.Computer.Audio.Play(My.Resources.smallwin, AudioPlayMode.Background)
            BalUpdate(1 * intMultiplier)
        Else
            lblDeclaration.Text = "        Better Luck Next Time"
        End If

    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        My.Computer.Audio.Play(My.Resources.slot_machine_pull_lever_spin_stop, AudioPlayMode.Background)
        intMultiplier = Convert.ToInt32(nudBet.Value)
        BalUpdate(-intMultiplier)
        Timer1.Enabled = True
    End Sub

    Private Sub BalUpdate(winnings As Integer)
        intBal += winnings
        lblBalance.Text = intBal
        If intBal <= 0 Then
            lblDeclaration.Text = "        Game Over"
            btnSpin.Enabled = False
        End If
    End Sub

    Private Function MarqueeText(ByVal Data As String)
        Dim S1 As String = Data.Remove(0, 1)
        Dim S2 As String = Data(0)
        Return S1 & S2
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblDeclaration.Text = MarqueeText(lblDeclaration.Text)
    End Sub

End Class
