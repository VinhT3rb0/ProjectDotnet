   M S B A M L   `   `   `  ����   WpfApp2%    MaterialDesignDemo.FieldsLineUp   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  .���� $��10q�$
��Left=�$	��Top=�   PrimaryHueLightBrush.  (MaterialDesignThemes.Wpf.ColorZoneAssist    
Background#  �    " PrimaryHueLightForegroundBrush   
Foreground# �     Mode$ Custom=�����  �� Orientation$ 
Horizontal=�.+���  � 	Resources  �� 
TargetType  MaterialDesignSlider �� BasedOn �� Property �� Value " MaterialDesignCaptionTextBlock��%�   '��       7  '�� �     7  �� " ��8   .���  �@��IsSnapToTickEnabled$
 True����  � ��$
 10,0q���  � ��$ Center=���  � ��$	 130���� " ��8   .���  � ��$
 Left=���  � ��$
 10,0q�.+��� �� $��Consolas)�$�FontSize�� �� $��Italic$���� *Value+	 �� ElementName$	 FontSizeSlider��
 �� Mode$
 OneWay=��� -    ��Name$ FontSizeSlider�� � Maximum$ 24Q� � Minimum$ 8Q� � Value$ 14Q��� �� $��Consolas)�$�Padding���� �� $�
horizontal�� �� $��Italic$���� *Value+$	 HorizontalPaddingSlider��$
 OneWay=��� -   $ HorizontalPaddingSlider��$ 16Q�$ 0Q�$ 0Q��� �� $��Consolas)�$�Padding���� �� $�vertical�� �� $��Italic$���� *Value+$	 VerticalPaddingSlider��$
 OneWay=��� -   $ VerticalPaddingSlider��$ 16Q�$ 0Q�$ 4Q��� �� $��Consolas)�$'�!TextFieldAssist.TextBoxViewMargin���� �� $�
horizontal�� �� $��Italic$���� *Value+$'	 !HorizontalTextBoxViewMarginSlider��$
 OneWay=��� -   $' !HorizontalTextBoxViewMarginSlider��$ 16Q�$ 0Q�$ 4Q���    MaterialDesignTextBox)  #MaterialDesignThemes.Wpf.HintAssist��%�   '��       7  �� " ��8   .���  � ��$ Consolas)���  � ��$
 Left=���  � ��$
 10,2q���  � ��$	 200����  � ��$ Center=���  �@ 
IsFloating$
 True��.+��� -    ��Name$ HintTextBox��   Hint$ HintAssist.Hint��$
��Hint���� -   $ HelperTextBox��$ HintAssist.HelperText���� -   $ ValidationErrorTextBox��$ Validation error���� -   $ PrefixTextBox��$  TextFieldAssist.PrefixText���� -	   $ SuffixTextBox��$  TextFieldAssist.SuffixText����    MaterialDesignCheckBox��%l   '��       7  �� " ��8   .���  � ��$ Consolas)���  � ��$
 Left=���  � ��$
 10,4q�.+��� -
    ��Name$ IsEnabledCheckBox��$��	IsEnabled�� d� 	IsChecked$
 TrueY��� -   $ HasClearButtonCheckBox��$$��TextFieldAssist.HasClearButton���� -   $ IsEditableCheckBox��$��ComboBox.IsEditable��.���� .+�� -    �Name$ FieldsLineUpGrid��$
��Left=�{��� *	IsChecked+$	 IsEnabledCheckBox������ *Value+$	 FontSizeSlider��   StyleHeader  FieldHeader  NotAvailable��%�  &	       7  &	 |     7  &	 �     7  �� " ��8   .���  � ��$
 Left=���  � ��$
 10,0q���  �@J�Opacity$
 0.56Q���  � ��$ Center=��� " ��8   .���  � ��$ Center=���  � ��$	 0,6q���  �@J�Opacity$
 0.56Q���  � ��$	 Top=��� " ��8   .���  � ��$ Center=���  �@J�Opacity$
 0.24Q���  � ��$	 N/A����  � ��$ Center=� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $	��100���� $	��100���� $	��100���� $	��100���� $	��100��.+��� $��1��$��0��#��[ $��Default���� $��2��$��0��#��[ $��Floating���� $��3��$��0��#��[ $��Filled���� $��4��$��0��#��[ $��Outlined���� $��0��$��1��#��[ $��	TextField���� $��0��$��2��#��[ $��PasswordBox���� $��0��$��3��#��[ $��ComboBox���� $��0��$��4��#��[ $��
DatePicker���� $��0��$��5��#��[ $��
TimePicker���� $��1��$��1���� $��2��$��1��   
IsFloating$
 True���� $��3��$��1�� 	 MaterialDesignFilledTextBox#��[	 �� $��4��$��1�� !
 MaterialDesignOutlinedTextBox#��[
 G� $��1��$��2��G� $��2��$��2��$
 True��G� $��3��$��2�� # MaterialDesignFilledPasswordBox#��[ G� $��4��$��2�� % !MaterialDesignOutlinedPasswordBox#��[ �� $��1��$��3���� $��2��$��3��$
 true���� $��3��$��3��   MaterialDesignFilledComboBox#��[ �� $��4��$��3�� " MaterialDesignOutlinedComboBox#��[ (  "System.Windows.Controls.DatePicker  $��1��$��4��  $��2��$��4��$
 True��  $��3��$��4�� " MaterialDesignFilledDatePicker#��[   $��4��$��4�� $  MaterialDesignOutlinedDatePicker#��[ )  #MaterialDesignThemes.Wpf.TimePicker  $��1��$��5��  $��2��$��5�� ( $MaterialDesignFloatingHintTimePicker#��[   $��3��$��5�� " MaterialDesignFilledTimePicker#��[   $��4��$��5�� $  MaterialDesignOutlinedTimePicker#��[ 