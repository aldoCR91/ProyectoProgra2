<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularMontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarTablaDeAmortizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosRegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeInteresesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTablaDeInteresesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.CalcularMontoToolStripMenuItem, Me.ConsultarTablaDeAmortizaciónToolStripMenuItem, Me.DatosRegistradosToolStripMenuItem, Me.MantenimientoDeInteresesToolStripMenuItem, Me.ModificarTablaDeInteresesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'CalcularMontoToolStripMenuItem
        '
        Me.CalcularMontoToolStripMenuItem.Name = "CalcularMontoToolStripMenuItem"
        Me.CalcularMontoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.CalcularMontoToolStripMenuItem.Text = "Calcular monto"
        '
        'ConsultarTablaDeAmortizaciónToolStripMenuItem
        '
        Me.ConsultarTablaDeAmortizaciónToolStripMenuItem.Name = "ConsultarTablaDeAmortizaciónToolStripMenuItem"
        Me.ConsultarTablaDeAmortizaciónToolStripMenuItem.Size = New System.Drawing.Size(187, 20)
        Me.ConsultarTablaDeAmortizaciónToolStripMenuItem.Text = "Consultar tabla de amortización"
        '
        'DatosRegistradosToolStripMenuItem
        '
        Me.DatosRegistradosToolStripMenuItem.Name = "DatosRegistradosToolStripMenuItem"
        Me.DatosRegistradosToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.DatosRegistradosToolStripMenuItem.Text = "Datos registrados"
        '
        'MantenimientoDeInteresesToolStripMenuItem
        '
        Me.MantenimientoDeInteresesToolStripMenuItem.Name = "MantenimientoDeInteresesToolStripMenuItem"
        Me.MantenimientoDeInteresesToolStripMenuItem.Size = New System.Drawing.Size(166, 20)
        Me.MantenimientoDeInteresesToolStripMenuItem.Text = "Mantenimiento de intereses"
        '
        'ModificarTablaDeInteresesToolStripMenuItem
        '
        Me.ModificarTablaDeInteresesToolStripMenuItem.Name = "ModificarTablaDeInteresesToolStripMenuItem"
        Me.ModificarTablaDeInteresesToolStripMenuItem.Size = New System.Drawing.Size(164, 20)
        Me.ModificarTablaDeInteresesToolStripMenuItem.Text = "Modificar tabla de intereses"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Pantalla de calculos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularMontoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarTablaDeAmortizaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosRegistradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoDeInteresesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarTablaDeInteresesToolStripMenuItem As ToolStripMenuItem
End Class
