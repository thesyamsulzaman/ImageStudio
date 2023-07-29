<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pictureDisplay = New PictureBox()
        buttonLoad = New Button()
        openFileDialog = New OpenFileDialog()
        convertImage = New Button()
        CType(pictureDisplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureDisplay
        ' 
        pictureDisplay.BackColor = SystemColors.ControlDark
        pictureDisplay.BorderStyle = BorderStyle.Fixed3D
        pictureDisplay.Location = New Point(12, 12)
        pictureDisplay.Name = "pictureDisplay"
        pictureDisplay.Size = New Size(645, 426)
        pictureDisplay.TabIndex = 0
        pictureDisplay.TabStop = False
        ' 
        ' buttonLoad
        ' 
        buttonLoad.Location = New Point(663, 12)
        buttonLoad.Name = "buttonLoad"
        buttonLoad.Size = New Size(125, 36)
        buttonLoad.TabIndex = 1
        buttonLoad.Text = "Load Image"
        buttonLoad.UseVisualStyleBackColor = True
        ' 
        ' openFileDialog
        ' 
        openFileDialog.FileName = "openFileDialog"
        ' 
        ' convertImage
        ' 
        convertImage.Location = New Point(663, 54)
        convertImage.Name = "convertImage"
        convertImage.Size = New Size(125, 39)
        convertImage.TabIndex = 2
        convertImage.Text = "Convert Image"
        convertImage.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(convertImage)
        Controls.Add(buttonLoad)
        Controls.Add(pictureDisplay)
        Name = "Form1"
        Text = "Form1"
        CType(pictureDisplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pictureDisplay As PictureBox
    Friend WithEvents buttonLoad As Button
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents convertImage As Button
End Class
