Public Class AltasProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltasProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If CmbLocalidad.SelectedValue = Nothing Then
            MsgBox("Elija una localidad")
            Exit Sub
        End If
        If CUITTextBox.Text = Nothing Then
            MsgBox("Ingrese el CUIT")
            Exit Sub
        End If
        Me.ProveedoresBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.ProveedoresBindingSource.Current("Razon_Social") = Razon_SocialTextBox.Text
        Me.ProveedoresBindingSource.Current("CUIT") = Val(CUITTextBox.Text)
        Me.ProveedoresBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.ProveedoresBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.ProveedoresBindingSource.Current("54") = Val(_54TextBox.Text)
        Me.ProveedoresBindingSource.Current("011") = Val(_011TextBox.Text)
        Me.ProveedoresBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores) 'actualizo en altas
        Prov.ProveedoresTableAdapter.Fill(Prov.ZapateriaDataSet.Proveedores) 'actualizo en principal para que muestre el cod del art
        Alta_Producto.ProveedoresTableAdapter.Fill(Alta_Producto.ZapateriaDataSet.Proveedores)
        Me.ProveedoresBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de proveedor es:" + Me.ProveedoresBindingSource.Current("ID_Proveedor").ToString)
        Me.ProveedoresBindingSource.AddNew()



    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub AltasProv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub ProveedoresBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub CUITTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CUITTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub NroTextBox_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NroTextBox.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub _54TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _54TextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub _011TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _011TextBox.KeyPress
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
End Class