Imports System.Windows.Forms ' Timer sınıfı bu ad alanında bulunur
Imports System.Net
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Diagnostics

Public Class Form1



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.upcheck = True Then
            MsgBox("güncelleme kontrol ediliyor mesaj 1")
        End If
        Dim eskiDosyaYolu As String = Path.Combine(Application.StartupPath, "thumb.gif")
        If File.Exists(eskiDosyaYolu) Then
            File.Delete(eskiDosyaYolu)
        End If
        ' İndirmek istediğiniz GIF dosyasının URL'sini belirtin
        Dim gifUrl As String = "https://raw.githubusercontent.com/turkuvazbiri/WoTLK-Turk-Client/main/thumb-wotlk.gif"

        ' Dosyanın indirileceği yerel dosya yolu
        Dim localFilePath As String = Path.Combine(Application.StartupPath, "thumb.gif")

        ' WebClient nesnesini kullanarak GIF dosyasını indirin
        Dim webClient As New WebClient()
        webClient.DownloadFile(gifUrl, localFilePath)

        ' PictureBox'a indirilen GIF dosyasını yükle
        PictureBox1.Image = Image.FromFile(localFilePath)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists(My.Settings.dosyayolu) Then
            Dim process As New Process()

            ' İşlemi başlatmak için işlem bilgilerini doğrudan ayarlayabilirsiniz
            process.StartInfo.FileName = My.Settings.dosyayolu

            ' İşlemi başlat
            process.Start()

            ' İşlemi beklemek isterseniz aşağıdaki satırları ekleyebilirsiniz
            ' process.WaitForExit()
            ' process.Close()
        Else
            MessageBox.Show("Lütfen öncelikle WoW.exe'nin konumunu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If My.Settings.otokapat = True Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ayar.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Açmak istediğiniz web sitesinin URL'sini belirtin
        Dim websiteUrl As String = "https://www.wowhead.com/"

        ' Process nesnesi oluşturun
        Dim webBrowserProcess As New Process()

        ' Web tarayıcısını başlatmak için varsayılan web tarayıcısını kullanın
        webBrowserProcess.StartInfo.FileName = websiteUrl

        ' İşlemi başlat
        webBrowserProcess.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Açmak istediğiniz web sitesinin URL'sini belirtin
        Dim websiteUrl As String = "https://www.icy-veins.com/wotlk-classic/"

        ' Process nesnesi oluşturun
        Dim webBrowserProcess As New Process()

        ' Web tarayıcısını başlatmak için varsayılan web tarayıcısını kullanın
        webBrowserProcess.StartInfo.FileName = websiteUrl

        ' İşlemi başlat
        webBrowserProcess.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Açmak istediğiniz web sitesinin URL'sini belirtin
        Dim websiteUrl As String = "https://www.warmane.com/"

        ' Process nesnesi oluşturun
        Dim webBrowserProcess As New Process()

        ' Web tarayıcısını başlatmak için varsayılan web tarayıcısını kullanın
        webBrowserProcess.StartInfo.FileName = websiteUrl

        ' İşlemi başlat
        webBrowserProcess.Start()
    End Sub
End Class


