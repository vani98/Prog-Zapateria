﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarLoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ZonaLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MostrarLoc))
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ZonaTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.BtnPrincipio = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnAdelante = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ZonaLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        ID_LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel.Location = New System.Drawing.Point(12, 9)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(83, 13)
        ID_LocalidadLabel.TabIndex = 1
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocalidadLabel.Location = New System.Drawing.Point(12, 35)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(66, 13)
        LocalidadLabel.TabIndex = 3
        LocalidadLabel.Text = "Localidad:"
        '
        'ZonaLabel
        '
        ZonaLabel.AutoSize = True
        ZonaLabel.BackColor = System.Drawing.Color.Transparent
        ZonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZonaLabel.Location = New System.Drawing.Point(12, 61)
        ZonaLabel.Name = "ZonaLabel"
        ZonaLabel.Size = New System.Drawing.Size(40, 13)
        ZonaLabel.TabIndex = 5
        ZonaLabel.Text = "Zona:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.BackColor = System.Drawing.Color.Transparent
        CPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLabel.Location = New System.Drawing.Point(12, 87)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(27, 13)
        CPLabel.TabIndex = 7
        CPLabel.Text = "CP:"
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(101, 6)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 2
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(101, 32)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalidadTextBox.TabIndex = 4
        '
        'ZonaTextBox
        '
        Me.ZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Zona", True))
        Me.ZonaTextBox.Location = New System.Drawing.Point(101, 58)
        Me.ZonaTextBox.Name = "ZonaTextBox"
        Me.ZonaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZonaTextBox.TabIndex = 6
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(101, 84)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPTextBox.TabIndex = 8
        '
        'BtnPrincipio
        '
        Me.BtnPrincipio.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrincipio.BackgroundImage = CType(resources.GetObject("BtnPrincipio.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrincipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrincipio.Location = New System.Drawing.Point(15, 134)
        Me.BtnPrincipio.Name = "BtnPrincipio"
        Me.BtnPrincipio.Size = New System.Drawing.Size(40, 38)
        Me.BtnPrincipio.TabIndex = 9
        Me.BtnPrincipio.UseVisualStyleBackColor = False
        '
        'BtnAtras
        '
        Me.BtnAtras.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtras.BackgroundImage = CType(resources.GetObject("BtnAtras.BackgroundImage"), System.Drawing.Image)
        Me.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAtras.Location = New System.Drawing.Point(61, 134)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(40, 38)
        Me.BtnAtras.TabIndex = 10
        Me.BtnAtras.UseVisualStyleBackColor = False
        '
        'BtnAdelante
        '
        Me.BtnAdelante.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdelante.BackgroundImage = CType(resources.GetObject("BtnAdelante.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdelante.Location = New System.Drawing.Point(107, 134)
        Me.BtnAdelante.Name = "BtnAdelante"
        Me.BtnAdelante.Size = New System.Drawing.Size(40, 38)
        Me.BtnAdelante.TabIndex = 11
        Me.BtnAdelante.UseVisualStyleBackColor = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackColor = System.Drawing.Color.Transparent
        Me.BtnUltimo.BackgroundImage = CType(resources.GetObject("BtnUltimo.BackgroundImage"), System.Drawing.Image)
        Me.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUltimo.Location = New System.Drawing.Point(153, 134)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(40, 38)
        Me.BtnUltimo.TabIndex = 12
        Me.BtnUltimo.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolver.Location = New System.Drawing.Point(237, 97)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 43)
        Me.BtnVolver.TabIndex = 13
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscar.Location = New System.Drawing.Point(237, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 43)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'MostrarLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(328, 180)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnAdelante)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnPrincipio)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(ZonaLabel)
        Me.Controls.Add(Me.ZonaTextBox)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.CPTextBox)
        Me.KeyPreview = True
        Me.Name = "MostrarLoc"
        Me.Text = "MostrarLoc"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZonaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrincipio As System.Windows.Forms.Button
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents BtnAdelante As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
End Class
