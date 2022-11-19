Public Class Form1


    Private Sub bttCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCLOSE.Click
        Me.Close()
    End Sub

    Private Sub bttCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCLEAR.Click
        Dim result As DialogResult
        result = MessageBox.Show("ลบข้อมูล", "ยืนยันการลบ", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            txtPRICE.Clear()
            txtTOTAL.Clear()
            txtPRICE.Focus()
        Else
            txtTOTAL.Focus()
        End If

        lblCOUNT.Text = "(ชิ้น)"


        If chkSTRAWBERRY.Checked = True Then
            chkSTRAWBERRY.Checked = False
        End If

        If chkGOLDENCANDY.Checked = True Then
            chkGOLDENCANDY.Checked = False
        End If

        If chkORANGE.Checked = True Then
            chkORANGE.Checked = False
        End If

        If chkCHOCOLATE.Checked = True Then
            chkCHOCOLATE.Checked = False
        End If

        If chkTEATHAI.Checked = True Then
            chkTEATHAI.Checked = False
        End If

        If chkTIRAMISU.Checked = True Then
            chkTIRAMISU.Checked = False
        End If

        If chkBLUBERRYCHEESECAKE.Checked = True Then
            chkBLUBERRYCHEESECAKE.Checked = False
        End If

        If chkJAMROLLS.Checked = True Then
            chkJAMROLLS.Checked = False
        End If

        If chkBANANA.Checked = True Then
            chkBANANA.Checked = False
        End If

        If chkBROWNIES.Checked = True Then
            chkBROWNIES.Checked = False
        End If

        If chkTAIWANMILKTEA.Checked = True Then
            chkTAIWANMILKTEA.Checked = False
        End If

        If chkCAPPUCCINO.Checked = True Then
            chkCAPPUCCINO.Checked = False
        End If

        If chkLATTE.Checked = True Then
            chkLATTE.Checked = False
        End If

        If chkMATCHALATTE.Checked = True Then
            chkMATCHALATTE.Checked = False
        End If

        If chkCOCOA.Checked = True Then
            chkCOCOA.Checked = False
        End If

        If rbtZEROPOINTFIVEPOUND.Checked Then
            rbtZEROPOINTFIVEPOUND.Checked = False
        ElseIf rbtONEPOUND.Checked Then
            rbtONEPOUND.Checked = False
        ElseIf rbtTWOPOUND.Checked Then
            rbtTWOPOUND.Checked = False
        End If

        If rbtSMALL.Checked Then
            rbtSMALL.Checked = False
        ElseIf rbtMEDIUM.Checked Then
            rbtMEDIUM.Checked = False
        ElseIf rbtLARGE.Checked Then
            rbtLARGE.Checked = False
        End If

    End Sub

    Private Sub bttCOUNT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCOUNT.Click
        Dim a, b, c, d, f, g, h, total, count As Integer
        a = 10
        b = 20
        c = 40
        d = 50
        f = 25
        g = 30
        h = 45

        If chkSTRAWBERRY.Checked Then
            total += a
            count += 1
        End If

        If chkGOLDENCANDY.Checked Then
            total += a
            count += 1
        End If

        If chkORANGE.Checked Then
            total += b
            count += 1
        End If

        If chkCHOCOLATE.Checked Then
            total += b
            count += 1
        End If

        If chkTEATHAI.Checked Then
            total += b
            count += 1
        End If

        If chkTIRAMISU.Checked Then
            total += a
            count += 1
        End If

        If chkBLUBERRYCHEESECAKE.Checked Then
            total += b
            count += 1
        End If

        If chkJAMROLLS.Checked Then
            total += c
            count += 1
        End If

        If chkBANANA.Checked Then
            total += d
            count += 1
        End If

        If chkBROWNIES.Checked Then
            total += c
            count += 1
        End If

        If chkTAIWANMILKTEA.Checked Then
            total += f
            count += 1
        End If

        If chkCAPPUCCINO.Checked Then
            total += g
            count += 1
        End If

        If chkLATTE.Checked Then
            total += g
            count += 1
        End If

        If chkMATCHALATTE.Checked Then
            total += g
            count += 1
        End If

        If chkCOCOA.Checked Then
            total += h
            count += 1
        End If

        txtPRICE.Text = total
        lblCOUNT.Text = count

        If rbtZEROPOINTFIVEPOUND.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text)
        ElseIf rbtONEPOUND.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text) + 279
        ElseIf rbtTWOPOUND.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text) + 549
        End If

        If rbtSMALL.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text)
        ElseIf rbtMEDIUM.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text) + 10
        ElseIf rbtLARGE.Checked Then
            txtPRICE.Text = Val(txtPRICE.Text) + 20
        End If



    End Sub

    Private Sub bttTOTAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTOTAL.Click
        Dim i As Integer
        If Val(ListBox1.SelectedItems.Count) Then
            ListBox1.Text = i
        End If
        txtTOTAL.Text = ListBox1.SelectedItem * Val(txtPRICE.Text)

        DataGridView1.Rows(0).Cells(4).Value = Val(txtTOTAL.Text)
        DataGridView1.Rows(0).Cells(3).Value = ListBox1.SelectedItem
        If rbtSMALL.Checked Then
            DataGridView1.Rows(0).Cells(2).Value = "แก้วเล็ก"
        ElseIf rbtMEDIUM.Checked Then
            DataGridView1.Rows(0).Cells(2).Value = "แก้วกลาง"
        ElseIf rbtLARGE.Checked Then
            DataGridView1.Rows(0).Cells(2).Value = "แก้วใหญ่"
        End If
        If rbtZEROPOINTFIVEPOUND.Checked Then
            DataGridView1.Rows(0).Cells(1).Value = "0.5 ปอนด์"
        ElseIf rbtONEPOUND.Checked Then
            DataGridView1.Rows(0).Cells(1).Value = "1 ปอนด์"
        ElseIf rbtTWOPOUND.Checked Then
            DataGridView1.Rows(0).Cells(1).Value = "2 ปอนด์"
        End If
        DataGridView1.Rows(0).Cells(0).Value = Val(lblCOUNT.Text)


    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub bttBUY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBUY.Click
        Dim result As DialogResult
        result = MessageBox.Show("การชำระเงิน", "ยืนยันการชำระเงิน", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            txtPRICE.Clear()
            txtTOTAL.Clear()
            txtPRICE.Focus()
        Else
            txtTOTAL.Focus()
        End If

        If chkSTRAWBERRY.Checked = True Then
            chkSTRAWBERRY.Checked = False
        End If

        If chkGOLDENCANDY.Checked = True Then
            chkGOLDENCANDY.Checked = False
        End If

        If chkORANGE.Checked = True Then
            chkORANGE.Checked = False
        End If

        If chkCHOCOLATE.Checked = True Then
            chkCHOCOLATE.Checked = False
        End If

        If chkTEATHAI.Checked = True Then
            chkTEATHAI.Checked = False
        End If

        If chkTIRAMISU.Checked = True Then
            chkTIRAMISU.Checked = False
        End If

        If chkBLUBERRYCHEESECAKE.Checked = True Then
            chkBLUBERRYCHEESECAKE.Checked = False
        End If

        If chkJAMROLLS.Checked = True Then
            chkJAMROLLS.Checked = False
        End If

        If chkBANANA.Checked = True Then
            chkBANANA.Checked = False
        End If

        If chkBROWNIES.Checked = True Then
            chkBROWNIES.Checked = False
        End If

        If chkTAIWANMILKTEA.Checked = True Then
            chkTAIWANMILKTEA.Checked = False
        End If

        If chkCAPPUCCINO.Checked = True Then
            chkCAPPUCCINO.Checked = False
        End If

        If chkLATTE.Checked = True Then
            chkLATTE.Checked = False
        End If

        If chkMATCHALATTE.Checked = True Then
            chkMATCHALATTE.Checked = False
        End If

        If chkCOCOA.Checked = True Then
            chkCOCOA.Checked = False
        End If

        If rbtZEROPOINTFIVEPOUND.Checked Then
            rbtZEROPOINTFIVEPOUND.Checked = False
        ElseIf rbtONEPOUND.Checked Then
            rbtONEPOUND.Checked = False
        ElseIf rbtTWOPOUND.Checked Then
            rbtTWOPOUND.Checked = False
        End If

        If rbtSMALL.Checked Then
            rbtSMALL.Checked = False
        ElseIf rbtMEDIUM.Checked Then
            rbtMEDIUM.Checked = False
        ElseIf rbtLARGE.Checked Then
            rbtLARGE.Checked = False
        End If


        lblCOUNT.Text = "(ชิ้น)"



    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub bttCALCULATOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCALCULATOR.Click
        Cal.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("HH:mm:ss")
        Label5.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub chkJAMROLLS_CheckedChanged(sender As Object, e As EventArgs) Handles chkJAMROLLS.CheckedChanged

    End Sub
End Class
