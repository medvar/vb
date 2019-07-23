<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbUsuario = New System.Windows.Forms.TextBox()
        Me.TxbContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BnIngresar
        '
        Me.BnIngresar.Location = New System.Drawing.Point(282, 304)
        Me.BnIngresar.Name = "BnIngresar"
        Me.BnIngresar.Size = New System.Drawing.Size(114, 55)
        Me.BnIngresar.TabIndex = 0
        Me.BnIngresar.Text = "Ingresar"
        Me.BnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'TxbUsuario
        '
        Me.TxbUsuario.Location = New System.Drawing.Point(252, 166)
        Me.TxbUsuario.Name = "TxbUsuario"
        Me.TxbUsuario.Size = New System.Drawing.Size(204, 22)
        Me.TxbUsuario.TabIndex = 2
        '
        'TxbContraseña
        '
        Me.TxbContraseña.Location = New System.Drawing.Point(252, 234)
        Me.TxbContraseña.Name = "TxbContraseña"
        Me.TxbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxbContraseña.Size = New System.Drawing.Size(204, 22)
        Me.TxbContraseña.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 570)
        Me.Controls.Add(Me.TxbContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BnIngresar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BnIngresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbUsuario As TextBox
    Friend WithEvents TxbContraseña As TextBox
    Friend WithEvents Label2 As Label
End Class
