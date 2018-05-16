!  Salford Software FTN95 .NET for Visual Studio .NET
!  --------------------------------------------------
!  Free Format FTN95 Source File
!
!    Filename: MessageBox.f95
!    Author: Silverfrost
!    Notes: See the documentation for more details
!
!  --------------------------------------------------

program MessageBox
  assembly_external (name="System.Windows.Forms.MessageBox.Show") showMessageBox 
  object ("System.Windows.Forms.DialogResult") dialogResult
  dialogResult = showMessageBox ("Hello from the Salford Software FTN95 .NET team!", "Hello")
end
