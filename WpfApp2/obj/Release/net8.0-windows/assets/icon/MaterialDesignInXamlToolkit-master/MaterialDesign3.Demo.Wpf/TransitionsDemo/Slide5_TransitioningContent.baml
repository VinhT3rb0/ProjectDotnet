   M S B A M L   `   `   `  ����   WpfApp2E    ?MaterialDesign3Demo.TransitionsDemo.Slide5_TransitioningContent   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006     MaterialDesignPaper#���   .��� $	��418��$��Center=�  � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration 0:0:1.2.��(  "MaterialDesignThemes.Wpf.ColorZone  $��4q�.  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp6=�   Mode$ 
PrimaryMid=�.���� $��16q� �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  $��32��$��32��   Kind$ Account=��� $��16,0,0,0q� $  MaterialDesignHeadline5TextBlock#��[ 
Contacts�� $��1������ .R�A�  A� Columns$ 4�� � 	Resources 	 �� 
TargetType
 �� BasedOn �� Property �� Value��%�   '        7 �� "	  8
   .���  � ��$ 96����  � ��$ 4q���  �@ Mode$ PrimaryLight=���  � ��$ 96��.@�     *
ExpandIn+.��  .��  $��Center=�$��Center=�$ Phone=�     OpeningEffectsOffset O  IMaterialDesignThemes.Wpf.Transitions.IndexedItemOffsetMultiplierExtension  *
0:0:0.05+   OpeningEffects ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect     Kind$ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=�     *
0:0:0.05+   $ ExpandIn=�.��  .��  $��Center=�$��Center=�$ Phone=��� $��2��$��Right=�$ 
Horizontal=�.+��� $��16q�$
��Left=�$��Center=�7	  1MaterialDesignThemes.Wpf.Transitions.Transitioner 	  MovePreviousCommand#��Z  * &MaterialDesignFloatingActionMiniButton#��[ .��  $ StepBackward=��� $��16q�$	��Top=� 	  MoveNextCommand#��Z  / +MaterialDesignFloatingActionSecondaryButton#��[ .��  $ StepForward=�