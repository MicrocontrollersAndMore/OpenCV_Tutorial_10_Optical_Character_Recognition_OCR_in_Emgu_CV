Option Strict

Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure
Imports Emgu.CV.UI
Imports Emgu.CV.CvEnum

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class frmOCR

' member variables ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Dim blnFirstTimeInResizeEvent As Boolean = True
Dim intOrigFormWidth As Integer
Dim intOrigFormHeight As Integer
Dim intOrigTableLayoutPanelWidth As Integer
Dim intOrigTableLayoutPanelHeight As Integer

Dim imgImage As Image(Of Bgr, Byte) = Nothing
Dim imgBlank As Image(Of Bgr, Byte) = Nothing

Dim tess As Tesseract

' constructor '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub New()
	InitializeComponent()						' This call is required by the designer.
	
	intOrigFormWidth = Me.Width
	intOrigFormHeight = Me.Height
	intOrigTableLayoutPanelWidth = tlpTextBoxAndImageBox.Width
	intOrigTableLayoutPanelHeight = tlpTextBoxAndImageBox.Height

	Try
		tess = New Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_DEFAULT)
	Catch ex As Exception
		Me.Text = "error instantiating Tesseract"
		txtOCR.Text = "error instantiating Tesseract"
		txtFile.Enabled = False
		btnFile.Enabled = False
		Return
	End Try
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub frmOCR_Resize( sender As System.Object,  e As System.EventArgs) Handles MyBase.Resize
	'This If Else statement is necessary to throw out the first time the Form1_Resize event is called.
	'For some reason, in VB.NET the Resize event is called once before the constructor, then the constructor is called,
	'then the Resize event is called each time the form is resized.  The first time the Resize event is called
	'(i.e. before the constructor is called) the coordinates of the components on the form all read zero,
	'therefore we have to throw out this first call, then the constructor will run and get the correct initial
	'component location data, then every time after that we can let the Resize event run as expected
	If(blnFirstTimeInResizeEvent = True) Then
		blnFirstTimeInResizeEvent = False
	Else
		tlpTextBoxAndImageBox.Width = Me.Width - (intOrigFormWidth - intOrigTableLayoutPanelWidth)
		tlpTextBoxAndImageBox.Height = Me.Height - (intOrigFormHeight - intOrigTableLayoutPanelHeight)
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub btnFile_Click( sender As System.Object,  e As System.EventArgs) Handles btnFile.Click
	Dim dialogResult As DialogResult = ofdFile.ShowDialog()

	If(dialogResult = Windows.Forms.DialogResult.OK Or dialogResult = Windows.Forms.DialogResult.Yes) Then
		txtFile.Text = ofdFile.FileName
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtFile_TextChanged( sender As System.Object,  e As System.EventArgs) Handles txtFile.TextChanged
	txtFile.SelectionStart = txtFile.Text.Length								'move caret to end of text box so file name is visible
	If(txtFile.Text <> String.Empty) Then
		ProcessImageAndUpdateGUI()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub ProcessImageAndUpdateGUI()	
	Try
		imgImage = New Image(Of Bgr, Byte)(txtFile.Text)
	Catch ex As Exception
		Me.Text = "error opening file"
		Return
	End Try
	
	If(imgImage Is Nothing) Then
		Return
	End If
	
	Me.Text = "processing, please wait . . ."
	ibImage.Image = imgBlank
	Application.DoEvents()
	
	tess.Recognize(imgImage)
	txtOCR.Text = tess.GetText()
	
	ibImage.Image = imgImage
	
	Me.Text = "done processing, choose another image if desired"
End Sub

End Class
