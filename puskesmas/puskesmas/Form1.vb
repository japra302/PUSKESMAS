Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Username dan Password yang disimpan secara hardcoded
        Dim savedUsername As String = "user"
        Dim savedPassword As String = "root"

        ' Mendapatkan input dari TextBox
        Dim inputUsername As String = TextBox1.Text
        Dim inputPassword As String = TextBox2.Text

        ' Memeriksa apakah input cocok dengan yang disimpan
        If inputUsername = savedUsername AndAlso inputPassword = savedPassword Then
            MessageBox.Show("Login Anda Berhasil!")
        Else
            MessageBox.Show("Login gagal! Periksa kembali username dan password.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Menutup aplikasi saat tombol keluar diklik
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Menampilkan atau menyembunyikan karakter kata sandi tergantung pada status CheckBox
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click

    End Sub
End Class
