﻿Imports System.Threading

Public Class Form1


    Public XVelocity(1000) As Integer
    Public YVelocity(1000) As Integer
    Public ParticleCoord(1000, 1) As Integer
    Public Blackbrush As New SolidBrush(Color.Black)
    Public Blackpen As New Pen(Color.Black, 1)
    Public RedPen As New Pen(Color.Red, 1)
    Public GreenPen As New Pen(Color.Green, 2)
    Public NumberOfParticles As Integer
    Public ParticleSize As Integer
    Public Running As Boolean = True
    Public WindowWidth As Integer
    Public WindowHeight As Integer
    Public ShowCoords As Boolean = False
    Public Collisions As Boolean = False
    Public Frames As Integer
    Public FPS As Integer
    Dim stopWatch As New Stopwatch()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'AddParticle()

        Console.WriteLine(Me.Height.ToString)

        'Blackpen.DashStyle = Drawing.Drawing2D.DashStyle.Dot

        stopWatch.Start()

    End Sub

    Private Sub AddParticle()
        Randomize()

        If NumberOfParticles < 1000 Then
            NumberOfParticles += 1

            YVelocity(NumberOfParticles) = CInt(Math.Ceiling(Rnd() * 10))
            XVelocity(NumberOfParticles) = CInt(Math.Ceiling(Rnd() * 10))

            ParticleCoord(NumberOfParticles, 0) = CInt(Math.Ceiling(Rnd() * (WindowWidth - ParticleSize)))
            ParticleCoord(NumberOfParticles, 1) = CInt(Math.Ceiling(Rnd() * (WindowHeight - ParticleSize)))

            Console.WriteLine("Particle " + NumberOfParticles.ToString + " Speeds: XVelocity = " + XVelocity(NumberOfParticles).ToString + ", YVelocity = " + YVelocity(NumberOfParticles).ToString)
            Console.WriteLine("Particle " + NumberOfParticles.ToString + " Coordinates: (" + ParticleCoord(NumberOfParticles, 0).ToString + ", " + ParticleCoord(NumberOfParticles, 1).ToString + ")")
        Else
            MessageBox.Show("Maximum Number of Particles Reached")
        End If
    End Sub

    Private Sub RemoveParticle()

        If NumberOfParticles > 0 Then
            NumberOfParticles -= 1

            YVelocity(NumberOfParticles) = Nothing
            XVelocity(NumberOfParticles) = Nothing

            ParticleCoord(NumberOfParticles, 0) = Nothing
            ParticleCoord(NumberOfParticles, 1) = Nothing

            Console.WriteLine("Particle " + (NumberOfParticles + 1).ToString + " Removed")
        Else
            MessageBox.Show("Minimum Number of Particles Reached")
        End If

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ParticleSize = ParticleSizeBar.Value()

        NumberOfParticlesLabel.Text = ("Number Of Particles: " + (NumberOfParticles).ToString)

        If Running = True Then
            Me.Invalidate()
        End If

        Dim ts As TimeSpan = stopWatch.Elapsed
        Dim results As Integer = String.Format(ts.TotalMilliseconds)

        Frames += 1

        If results > 1000 Then
            FPS = (Frames)
            FPSCounter.Text = ("FPS: " + FPS.ToString)
            stopWatch.Restart()
            Frames = 0
        End If


    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        WindowWidth = (Me.Width - 17)
        WindowHeight = (Me.Height - 220)

        e.Graphics.DrawRectangle(Blackpen, 0, 0, WindowWidth, WindowHeight)

        For i = 1 To NumberOfParticles
            If ParticleCoord(i, 0) < (WindowWidth - ParticleSize) And (ParticleCoord(i, 0) > 0) And ParticleCoord(i, 1) < (WindowHeight - ParticleSize) And ParticleCoord(i, 1) > 0 Then
                ParticleCoord(i, 0) = ParticleCoord(i, 0) + XVelocity(i)
                ParticleCoord(i, 1) = ParticleCoord(i, 1) + YVelocity(i)
                e.Graphics.FillEllipse(Blackbrush, ParticleCoord(i, 0), ParticleCoord(i, 1), ParticleSize, ParticleSize)
                If ShowCoords = True Then
                    e.Graphics.DrawString(("(" + (ParticleCoord(i, 0) + (ParticleSize / 2)).ToString + ", " + (ParticleCoord(i, 1) + (ParticleSize / 2)).ToString + ")"), New Font("Tahoma", 7), Brushes.Black, New Point((ParticleCoord(i, 0) + (ParticleSize / 2) - 22), (ParticleCoord(i, 1) + (ParticleSize))))
                    Dim DrawPointI As New Point((ParticleCoord(i, 0) + (ParticleSize / 2)), (ParticleCoord(i, 1) + (ParticleSize / 2)))
                    Dim DrawPointJ As New Point(((ParticleCoord(i, 0) + (ParticleSize / 2)) + (XVelocity(i) * 4)), ((ParticleCoord(i, 1) + (ParticleSize / 2)) + (YVelocity(i) * 4)))
                    Dim CentrePoints As Point() = {DrawPointI, DrawPointJ}
                    e.Graphics.DrawPolygon(GreenPen, CentrePoints)
                End If
            ElseIf ParticleCoord(i, 0) < (WindowWidth - ParticleSize) And ParticleCoord(i, 0) > 0 Then
                YVelocity(i) = -YVelocity(i)
                If ParticleCoord(i, 1) > 0 Then
                    ParticleCoord(i, 1) = (WindowHeight - (ParticleSize - YVelocity(i)))
                Else
                    ParticleCoord(i, 1) = ParticleCoord(i, 1) + YVelocity(i)
                End If
                ParticleCoord(i, 1) = ParticleCoord(i, 1) + YVelocity(i)
                e.Graphics.FillEllipse(Blackbrush, ParticleCoord(i, 0), ParticleCoord(i, 1), ParticleSize, ParticleSize)
            ElseIf ParticleCoord(i, 1) < (WindowHeight - ParticleSize) And ParticleCoord(i, 1) > 0 Then
                XVelocity(i) = -XVelocity(i)
                If ParticleCoord(i, 0) > 0 Then
                    ParticleCoord(i, 0) = (WindowWidth - (ParticleSize - XVelocity(i)))
                Else
                    ParticleCoord(i, 0) = ParticleCoord(i, 0) + XVelocity(i)
                End If
                ParticleCoord(i, 1) = ParticleCoord(i, 1) + YVelocity(i)
                e.Graphics.FillEllipse(Blackbrush, ParticleCoord(i, 0), ParticleCoord(i, 1), ParticleSize, ParticleSize)
            Else
                YVelocity(i) = -YVelocity(i)
                XVelocity(i) = -XVelocity(i)
                ParticleCoord(i, 0) = ParticleCoord(i, 0) + XVelocity(i)
                ParticleCoord(i, 1) = ParticleCoord(i, 1) + YVelocity(i)
            End If
        Next

        ''''''''''''''''''''''''''''''''''' COLLISION DETECTOR - Stops two particles if collision detected ''''''''''''''''''''''''''''
        Dim Evaluator1 = New System.Threading.Thread(Sub() CollisionDetector(1, (NumberOfParticles / 4)))
        Dim Evaluator2 = New System.Threading.Thread(Sub() CollisionDetector((NumberOfParticles / 4), (NumberOfParticles / 2)))
        Dim Evaluator3 = New System.Threading.Thread(Sub() CollisionDetector((NumberOfParticles / 2), ((NumberOfParticles / 2) + (NumberOfParticles / 4))))
        Dim Evaluator4 = New System.Threading.Thread(Sub() CollisionDetector(((NumberOfParticles / 2) + (NumberOfParticles / 4)), NumberOfParticles))

        Evaluator1.Start()
        Evaluator2.Start()
        Evaluator3.Start()
        Evaluator4.Start()


        Evaluator1.Join()
        Evaluator2.Join()
        Evaluator3.Join()
        Evaluator4.Join()

        'If Collisions = True Then
        '    For i = 1 To NumberOfParticles
        '        For j = 1 To (NumberOfParticles - i)
        '            If (ParticleCoord((i + j), 0) - ParticleCoord(i, 0)) ^ 2 + (ParticleCoord(i, 1) - ParticleCoord((i + j), 1)) ^ 2 <= ((ParticleSize / 2) + (ParticleSize / 2)) ^ 2 Then
        '                Dim CentrePointI() As Integer = {(ParticleCoord(i, 0) + (ParticleSize / 2)), (ParticleCoord(i, 1) + (ParticleSize / 2))}
        '                Dim CentrePointJ() As Integer = {(ParticleCoord(i + j, 0) + (ParticleSize / 2)), (ParticleCoord(i + j, 1) + (ParticleSize / 2))}
        '                Dim DrawPointI As New Point(CentrePointI(0), CentrePointI(1))
        '                Dim DrawPointJ As New Point(CentrePointJ(0), CentrePointJ(1))
        '                Dim CentrePoints As Point() = {DrawPointI, DrawPointJ}
        '                'Timer.Enabled = False
        '                e.Graphics.DrawPolygon(RedPen, CentrePoints)

        '                Dim Distance As Integer = Math.Sqrt(((CentrePointJ(0) - CentrePointI(0)) ^ 2) + ((CentrePointJ(1) - CentrePointI(1)) ^ 2))
        '                Console.WriteLine(Distance.ToString)

        '                ' Dim CentreWall() As Integer = ()


        '            End If
        '        Next
        '    Next
        'End If

    End Sub

    Private Sub Add10Button_Click(sender As Object, e As EventArgs) Handles Add10Button.Click
        For i = 0 To 9
            If NumberOfParticles < 1000 Then
                AddParticle()
            Else
                MessageBox.Show("Maximum Number of Particles Reached")
                Exit For
            End If
        Next
    End Sub

    Private Sub ResetSizeButton_Click(sender As Object, e As EventArgs) Handles ResetSizeButton.Click
        ParticleSizeBar.Value() = 25
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If Running = True Then
            Running = False
            PauseButton.Text = "Resume"
        Else
            Running = True
            PauseButton.Text = "Pause"
        End If
    End Sub

    Private Sub Add100Button_Click(sender As Object, e As EventArgs) Handles Add100Button.Click
        For i = 0 To 99
            If NumberOfParticles < 1000 Then
                AddParticle()
            Else
                MessageBox.Show("Maximum Number of Particles Reached")
                Exit For
            End If
        Next
    End Sub

    Private Sub IncreaseArrowButton_Click(sender As Object, e As EventArgs) Handles IncreaseArrowButton.MouseClick
        AddParticle()
    End Sub


    Private Sub DecreaseArrowButton_Click(sender As Object, e As EventArgs) Handles DecreaseArrowButton.Click
        RemoveParticle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        For i = 1 To NumberOfParticles
            RemoveParticle()
        Next
    End Sub

    Private Sub CoordsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CoordsCheckBox.CheckedChanged
        If CoordsCheckBox.Checked Then
            ShowCoords = True
        Else
            ShowCoords = False
        End If
    End Sub

    Private Sub CollisionsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CollisionsCheckBox.CheckedChanged
        If CollisionsCheckBox.Checked Then
            Collisions = True
        Else
            Collisions = False
        End If
    End Sub

    Sub CollisionDetector(Starter As Integer, Ender As Integer)

        If Collisions = True Then
            For i = Starter To (Ender / 2)
                For j = Starter To ((Ender / 2) - i)
                    If (ParticleCoord((i + j), 0) - ParticleCoord(i, 0)) ^ 2 + (ParticleCoord(i, 1) - ParticleCoord((i + j), 1)) ^ 2 <= ((ParticleSize / 2) + (ParticleSize / 2)) ^ 2 Then
                        Dim CentrePointI() As Integer = {(ParticleCoord(i, 0) + (ParticleSize / 2)), (ParticleCoord(i, 1) + (ParticleSize / 2))}
                        Dim CentrePointJ() As Integer = {(ParticleCoord(i + j, 0) + (ParticleSize / 2)), (ParticleCoord(i + j, 1) + (ParticleSize / 2))}
                        Dim DrawPointI As New Point(CentrePointI(0), CentrePointI(1))
                        Dim DrawPointJ As New Point(CentrePointJ(0), CentrePointJ(1))
                        Dim CentrePoints As Point() = {DrawPointI, DrawPointJ}
                        'Timer.Enabled = False
                        'e.Graphics.DrawPolygon(RedPen, CentrePoints)

                        Dim Distance As Integer = Math.Sqrt(((CentrePointJ(0) - CentrePointI(0)) ^ 2) + ((CentrePointJ(1) - CentrePointI(1)) ^ 2))
                        'Console.WriteLine(Distance.ToString)

                        ' Dim CentreWall() As Integer = ()


                    End If
                Next
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Running = True Then
            Me.Invalidate()
        End If

        Frames += 1
    End Sub
End Class