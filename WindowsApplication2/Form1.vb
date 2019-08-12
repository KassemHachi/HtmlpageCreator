Public Class Form1
    Sub create(ByVal bootstrap As Boolean, ByVal w3 As Boolean, ByVal mdl As Boolean, ByVal animate As Boolean)
        Try
            Dim html As String = ""
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(pathTxt.Text & "\" & PageName.Text & ".html", True)

            html += "<!DOCTYPE html>" & vbNewLine & "<html lang='en'>" & vbNewLine & "<head>" & vbNewLine & "<meta charset='UTF-8'>" & vbNewLine & "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" & vbNewLine & "<meta http-equiv='X-UA-Compatible' content='ie=edge'>" & vbNewLine
            If bootstrap = True Then
                html += "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>" & vbNewLine
            End If
            If mdl = True Then
                html += "<link rel='stylesheet' href='https://fonts.googleapis.com/icon?family=Material+Icons'>" & vbNewLine & "<link rel='stylesheet' href='https://code.getmdl.io/1.3.0/material.indigo-pink.min.css'>" & vbNewLine
            End If
            If w3 = True Then
                html += "<link rel='stylesheet' href='https://raw.githubusercontent.com/daneden/animate.css/master/animate.css' >" & vbNewLine
            End If
            html += "</head>" & vbNewLine & "<body>" & vbNewLine
            If bootstrap = True Then
                html += "<script src='https://code.jquery.com/jquery-3.3.1.slim.min.js' integrity='sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo' crossorigin='anonymous'></script>" & vbNewLine & "<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js' integrity='sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1' crossorigin='anonymous'></script>" & vbNewLine & "<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>" & vbNewLine
            End If
            html += "</body>" & vbNewLine & "</html>"
            file.Write(html)

            file.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FDB.ShowDialog()
        If FDB.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathTxt.Text = FDB.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bs = CheckedListBox1.GetItemChecked(0)
        animate = CheckedListBox1.GetItemChecked(1)
        w3 = CheckedListBox1.GetItemChecked(2)
        mdl = CheckedListBox1.GetItemChecked(3)

        create(bs, w3, mdl, animate)
    End Sub
    Dim bs As Boolean = False
    Dim animate As Boolean = False
    Dim w3 As Boolean = False
    Dim mdl As Boolean = False
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    

    End Sub
End Class
