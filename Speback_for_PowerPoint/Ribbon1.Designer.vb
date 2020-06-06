Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Windows.Forms クラス作成デザイナーのサポートに必要です
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'この呼び出しは、コンポーネント デザイナーで必要です。
        InitializeComponent()

    End Sub

    'Component は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
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

    'コンポーネント デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャはコンポーネント デザイナーで必要です。
    'コンポーネント デザイナーを使って変更できます。
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Box3 = Me.Factory.CreateRibbonBox
        Me.EditBox1 = Me.Factory.CreateRibbonEditBox
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.Label1 = Me.Factory.CreateRibbonLabel
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.Box4 = Me.Factory.CreateRibbonBox
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.Box2 = Me.Factory.CreateRibbonBox
        Me.CheckBox1 = Me.Factory.CreateRibbonCheckBox
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Box3.SuspendLayout()
        Me.Group3.SuspendLayout()
        Me.Box4.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.Box2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Label = "Speback"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Box3)
        Me.Group1.Label = "初期設定"
        Me.Group1.Name = "Group1"
        '
        'Box3
        '
        Me.Box3.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box3.Items.Add(Me.EditBox1)
        Me.Box3.Items.Add(Me.Button1)
        Me.Box3.Items.Add(Me.Label1)
        Me.Box3.Name = "Box3"
        '
        'EditBox1
        '
        Me.EditBox1.Label = "スライドトークン"
        Me.EditBox1.Name = "EditBox1"
        Me.EditBox1.Text = Nothing
        '
        'Button1
        '
        Me.Button1.Image = Global.Speback_for_PowerPoint.My.Resources.Resources.sort_alt
        Me.Button1.Label = "接続する"
        Me.Button1.Name = "Button1"
        Me.Button1.ShowImage = True
        '
        'Label1
        '
        Me.Label1.Label = "スライドトークンを入力してください"
        Me.Label1.Name = "Label1"
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.Box4)
        Me.Group3.Label = "webページ"
        Me.Group3.Name = "Group3"
        '
        'Box4
        '
        Me.Box4.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box4.Items.Add(Me.Button2)
        Me.Box4.Items.Add(Me.Button3)
        Me.Box4.Name = "Box4"
        '
        'Button2
        '
        Me.Button2.Image = Global.Speback_for_PowerPoint.My.Resources.Resources.people
        Me.Button2.Label = "視聴者用リンクを開く"
        Me.Button2.Name = "Button2"
        Me.Button2.ShowImage = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Speback_for_PowerPoint.My.Resources.Resources.presentation_alt
        Me.Button3.Label = "発表者用リンクを開く"
        Me.Button3.Name = "Button3"
        Me.Button3.ShowImage = True
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.Box2)
        Me.Group2.Label = "スライドショーの開始"
        Me.Group2.Name = "Group2"
        '
        'Box2
        '
        Me.Box2.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box2.Items.Add(Me.CheckBox1)
        Me.Box2.Items.Add(Me.Button4)
        Me.Box2.Name = "Box2"
        '
        'CheckBox1
        '
        Me.CheckBox1.Label = "このPCとSpeback上のスライドを同期する"
        Me.CheckBox1.Name = "CheckBox1"
        '
        'Button4
        '
        Me.Button4.Image = Global.Speback_for_PowerPoint.My.Resources.Resources.ui_play
        Me.Button4.Label = "最初のスライドから"
        Me.Button4.Name = "Button4"
        Me.Button4.ShowImage = True
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.PowerPoint.Presentation"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Box3.ResumeLayout(False)
        Me.Box3.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()
        Me.Box4.ResumeLayout(False)
        Me.Box4.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Box2.ResumeLayout(False)
        Me.Box2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Private WithEvents EditBox1 As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Box3 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Box2 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Box4 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents CheckBox1 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Private WithEvents Label1 As Microsoft.Office.Tools.Ribbon.RibbonLabel
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
