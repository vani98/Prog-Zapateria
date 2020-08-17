Public Class Form1

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)

    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ClientesBindingSource.Filter = Nothing
        Else
            Me.ClientesBindingSource.Filter = "Convert (ID_Cliente,'System.String') LIKE '%" & TextBox1.Text & "%'"
        End If
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Me.ClientesBindingSource.Filter = Nothing
        Else
            Me.ClientesBindingSource.Filter = "Convert (Nombre,'System.String') LIKE '%" & TextBox2.Text & "%'"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Me.ClientesBindingSource.Filter = Nothing
        Else
            Me.ClientesBindingSource.Filter = "Convert (Apellido,'System.String') LIKE '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Me.ClientesBindingSource.Filter = Nothing
        Else
            Me.ClientesBindingSource.Filter = "Convert (DNI,'System.String') LIKE '%" & TextBox4.Text & "%'"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AltaCli.Show()

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub ClientesDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ClientesDataGridView.CellMouseClick
        Dim fila As Integer
        fila = ClientesDataGridView.CurrentCellAddress.Y
            Ventas.TextBox6.Text = ClientesDataGridView(0, fila).Value()
            Ventas.TextBox6.Focus()
            Ventas.Show()
            Close()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call Button1_Click(sender, e)
        End If
    End Sub
End Class