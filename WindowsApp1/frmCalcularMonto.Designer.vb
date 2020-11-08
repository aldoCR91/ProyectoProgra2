<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcularMonto
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
        Me.DataGridViewTabla = New System.Windows.Forms.DataGridView()
        Me.colCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMensualidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIntereses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmortizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerarAmortizacion = New System.Windows.Forms.Button()
        Me.cboTipoMoneda = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.txtMontoPrestamo = New System.Windows.Forms.TextBox()
        Me.cboTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.lblCantidad2 = New System.Windows.Forms.Label()
        Me.lblPlazocredito2 = New System.Windows.Forms.Label()
        Me.lbltipodecredito2 = New System.Windows.Forms.Label()
        Me.txtMeses = New System.Windows.Forms.TextBox()
        Me.txtMostrarCuota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTabla
        '
        Me.DataGridViewTabla.AllowUserToAddRows = False
        Me.DataGridViewTabla.AllowUserToDeleteRows = False
        Me.DataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuota, Me.colMensualidad, Me.colIntereses, Me.colAmortizacion, Me.colSaldo})
        Me.DataGridViewTabla.Location = New System.Drawing.Point(111, 221)
        Me.DataGridViewTabla.Name = "DataGridViewTabla"
        Me.DataGridViewTabla.ReadOnly = True
        Me.DataGridViewTabla.Size = New System.Drawing.Size(586, 205)
        Me.DataGridViewTabla.TabIndex = 21
        '
        'colCuota
        '
        Me.colCuota.HeaderText = "Cuota"
        Me.colCuota.Name = "colCuota"
        Me.colCuota.ReadOnly = True
        '
        'colMensualidad
        '
        Me.colMensualidad.HeaderText = "Mensualidad"
        Me.colMensualidad.Name = "colMensualidad"
        Me.colMensualidad.ReadOnly = True
        '
        'colIntereses
        '
        Me.colIntereses.HeaderText = "Intereses mensuales"
        Me.colIntereses.Name = "colIntereses"
        Me.colIntereses.ReadOnly = True
        '
        'colAmortizacion
        '
        Me.colAmortizacion.HeaderText = "Amortizacion"
        Me.colAmortizacion.Name = "colAmortizacion"
        Me.colAmortizacion.ReadOnly = True
        '
        'colSaldo
        '
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.ReadOnly = True
        '
        'btnGenerarAmortizacion
        '
        Me.btnGenerarAmortizacion.Location = New System.Drawing.Point(698, 178)
        Me.btnGenerarAmortizacion.Name = "btnGenerarAmortizacion"
        Me.btnGenerarAmortizacion.Size = New System.Drawing.Size(75, 35)
        Me.btnGenerarAmortizacion.TabIndex = 20
        Me.btnGenerarAmortizacion.Text = "Ver tabla de cuotas"
        Me.btnGenerarAmortizacion.UseVisualStyleBackColor = True
        '
        'cboTipoMoneda
        '
        Me.cboTipoMoneda.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboTipoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMoneda.FormattingEnabled = True
        Me.cboTipoMoneda.Location = New System.Drawing.Point(601, 104)
        Me.cboTipoMoneda.Name = "cboTipoMoneda"
        Me.cboTipoMoneda.Size = New System.Drawing.Size(121, 28)
        Me.cboTipoMoneda.TabIndex = 19
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.BackColor = System.Drawing.Color.Turquoise
        Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblMoneda.Location = New System.Drawing.Point(655, 68)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(67, 20)
        Me.lblMoneda.TabIndex = 18
        Me.lblMoneda.Text = "Moneda"
        '
        'btCalcular
        '
        Me.btCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalcular.Location = New System.Drawing.Point(601, 178)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(75, 35)
        Me.btCalcular.TabIndex = 17
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'txtMontoPrestamo
        '
        Me.txtMontoPrestamo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtMontoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPrestamo.Location = New System.Drawing.Point(443, 104)
        Me.txtMontoPrestamo.Name = "txtMontoPrestamo"
        Me.txtMontoPrestamo.Size = New System.Drawing.Size(121, 26)
        Me.txtMontoPrestamo.TabIndex = 16
        '
        'cboTipoPrestamo
        '
        Me.cboTipoPrestamo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPrestamo.FormattingEnabled = True
        Me.cboTipoPrestamo.Location = New System.Drawing.Point(268, 102)
        Me.cboTipoPrestamo.Name = "cboTipoPrestamo"
        Me.cboTipoPrestamo.Size = New System.Drawing.Size(121, 28)
        Me.cboTipoPrestamo.TabIndex = 15
        '
        'lblCantidad2
        '
        Me.lblCantidad2.AutoSize = True
        Me.lblCantidad2.BackColor = System.Drawing.Color.Turquoise
        Me.lblCantidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCantidad2.Location = New System.Drawing.Point(472, 68)
        Me.lblCantidad2.Name = "lblCantidad2"
        Me.lblCantidad2.Size = New System.Drawing.Size(73, 20)
        Me.lblCantidad2.TabIndex = 13
        Me.lblCantidad2.Text = "Cantidad"
        '
        'lblPlazocredito2
        '
        Me.lblPlazocredito2.AutoSize = True
        Me.lblPlazocredito2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lblPlazocredito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazocredito2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPlazocredito2.Location = New System.Drawing.Point(12, 68)
        Me.lblPlazocredito2.Name = "lblPlazocredito2"
        Me.lblPlazocredito2.Size = New System.Drawing.Size(216, 20)
        Me.lblPlazocredito2.TabIndex = 12
        Me.lblPlazocredito2.Text = "Plazo de su credito en meses"
        '
        'lbltipodecredito2
        '
        Me.lbltipodecredito2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.lbltipodecredito2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodecredito2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbltipodecredito2.Location = New System.Drawing.Point(264, 68)
        Me.lbltipodecredito2.Name = "lbltipodecredito2"
        Me.lbltipodecredito2.Size = New System.Drawing.Size(159, 20)
        Me.lbltipodecredito2.TabIndex = 11
        Me.lbltipodecredito2.Text = "Tipo de credito"
        '
        'txtMeses
        '
        Me.txtMeses.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeses.Location = New System.Drawing.Point(64, 102)
        Me.txtMeses.Name = "txtMeses"
        Me.txtMeses.Size = New System.Drawing.Size(121, 26)
        Me.txtMeses.TabIndex = 22
        '
        'txtMostrarCuota
        '
        Me.txtMostrarCuota.Location = New System.Drawing.Point(443, 187)
        Me.txtMostrarCuota.Name = "txtMostrarCuota"
        Me.txtMostrarCuota.ReadOnly = True
        Me.txtMostrarCuota.Size = New System.Drawing.Size(121, 20)
        Me.txtMostrarCuota.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(222, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "La cuota del prestamo es:"
        '
        'frmCalcularMonto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.image
        Me.ClientSize = New System.Drawing.Size(786, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMostrarCuota)
        Me.Controls.Add(Me.txtMeses)
        Me.Controls.Add(Me.DataGridViewTabla)
        Me.Controls.Add(Me.btnGenerarAmortizacion)
        Me.Controls.Add(Me.cboTipoMoneda)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.txtMontoPrestamo)
        Me.Controls.Add(Me.cboTipoPrestamo)
        Me.Controls.Add(Me.lblCantidad2)
        Me.Controls.Add(Me.lblPlazocredito2)
        Me.Controls.Add(Me.lbltipodecredito2)
        Me.Name = "frmCalcularMonto"
        Me.Text = "frmCalcularMonto"
        CType(Me.DataGridViewTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTabla As DataGridView
    Friend WithEvents colCuota As DataGridViewTextBoxColumn
    Friend WithEvents colMensualidad As DataGridViewTextBoxColumn
    Friend WithEvents colIntereses As DataGridViewTextBoxColumn
    Friend WithEvents colAmortizacion As DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As DataGridViewTextBoxColumn
    Friend WithEvents btnGenerarAmortizacion As Button
    Friend WithEvents cboTipoMoneda As ComboBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents txtMontoPrestamo As TextBox
    Friend WithEvents cboTipoPrestamo As ComboBox
    Friend WithEvents lblCantidad2 As Label
    Friend WithEvents lblPlazocredito2 As Label
    Friend WithEvents lbltipodecredito2 As Label
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents txtMostrarCuota As TextBox
    Friend WithEvents Label1 As Label
End Class
