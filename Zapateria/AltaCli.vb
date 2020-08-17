Public Class AltaCli

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If CmbLocalidad.SelectedValue = Nothing Then
            MsgBox("Elija una localidad")
            Exit Sub
        End If
        If DNITextBox.Text = Nothing Then
            MsgBox("Ingrese el dni")
            Exit Sub
        End If
        Me.ClientesBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.ClientesBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.ClientesBindingSource.Current("Apellido") = ApellidoTextBox.Text
        Me.ClientesBindingSource.Current("Fec_Nacimiento") = Fec_NacimientoDateTimePicker.Value
        Me.ClientesBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.ClientesBindingSource.Current("DNI") = Val(DNITextBox.Text)
        Me.ClientesBindingSource.Current("54") = Val(Txb54.Text)
        Me.ClientesBindingSource.Current("011") = Val(Txb011.Text)
        Me.ClientesBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes) 'actualizo en altas
        Client.ClientesTableAdapter.Fill(Client.ZapateriaDataSet.Clientes) 'actualizo en principal para que muestre el cod del art
        Me.ClientesBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de Cliente es:" + Me.ClientesBindingSource.Current("ID_Cliente").ToString)
        Me.ClientesBindingSource.AddNew()


    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub AltaCli_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnGuardar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AltaLoc.Show()

    End Sub
    Private Sub DNITextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DNITextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub NombreTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub ApellidoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidoTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub NroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NroTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub


    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub


    Private Sub ClientesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Txb54_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txb54.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub Txb011_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txb011.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub
End Class