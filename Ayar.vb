Public Class Ayar
    Private Sub Ayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.upcheck
        CheckBox2.Checked = My.Settings.otokapat
        TextBox1.Text = My.Settings.dosyayolu
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' OpenFileDialog oluşturun
        Dim openFileDialog1 As New OpenFileDialog()

        ' Dosya seçme iletişim kutusu ayarlarını yapılandırın
        openFileDialog1.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*"
        openFileDialog1.Title = "WoW.exe Dosyasını Seçin"
        openFileDialog1.InitialDirectory = "C:\Program Files (x86)\" ' Varsayılan olarak başlatılan konum

        ' Dosya seçildiğinde
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Seçilen dosyanın yolunu Label2'ye yazdırın
            TextBox1.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        My.Settings.upcheck = CheckBox1.Checked
        My.Settings.dosyayolu = TextBox1.Text
        My.Settings.otokapat = CheckBox2.Checked
        My.Settings.Save()
        MsgBox("Ayarlar başarıyla kaydedildi.")
    End Sub
End Class