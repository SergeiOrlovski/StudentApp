   M S B A M L   `   `   `  ����F  BStudentsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StudentsApp.ControlsStudentsApp.Controls  5      ?$clr-namespace:StudentsApp.ConvertersStudentsApp.Converters  5      )clr-namespace:StudentsAppStudentsApp  5	      ?$clr-namespace:StudentsApp.ViewModelsStudentsApp.ViewModels  5          StudentsApp.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7controls"clr-namespace:StudentsApp.Controls     5      ;
converters$clr-namespace:StudentsApp.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      %localclr-namespace:StudentsApp  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      /user$clr-namespace:StudentsApp.ViewModels  5        � Title$  StudentsApp��5      $	��600��5      $	��360��5       � DataContext 5      2   ,StudentsApp.ViewModels.StudentsMainViewModel  5   
    � 	Resources 5      D   >StudentsApp.Converters.SelectedStudentEnableEditPanelConverter +  'SelectedStudentEnableEditPanelConverter�� 5   
   %   &	          5      6A   5      .��5      � $	��0,0q�6   $��Stretch=�6    � ColumnDefinitions 5   
   �� 5      $
��289* �6   �� 5      $
��302* �6   .+�5   
   �� $��1��6   $��4.6,5,4.6,0.2q�6%   .+�5      �� -   5         ��Name$ readStudentBut��5       $	��237��5!      $��30,2,0,0q�5"      $
��Left=�5#      $	��Top=�5$      $��View student��5&      ��5%      �� *ViewStudentsCommand+5&      �� 5'      -   5        $ addStudentBut��5(      $	��237��5)      $��	30,12,0,0q�5*      $
��Left=�5+      $	��Top=�5,      $��Add student��5.      ��5-      �� *AddStudentCommand+5.      �� 5/      -   5        $ delStudentBut��50      $	��237��51      $��	30,12,0,0q�52      $
��Left=�53      $	��Top=�54      $��Delete student��57      ��55      �� *DeleteStudentCommand+��56      �� *SelectedStudent+57      �� 58      -   5        $ updStudentBut��59      $	��237��5:      $��20��5;      $��	30,12,0,0q�5<      $
��Left=�5=      $	��Top=�5>      $��Save student��5A      ��5?      �� *UpdateStudentCommand+��5@      �� *SelectedStudent+ �� UpdateSourceTrigger$ PropertyChanged=�5A      �� 5B      $	��194��5C      $��	5,5,5.4,5q�5D       5E      �� *SelectedStudent+ �� Mode$ TwoWay=�{�5F      �� *SelectedItem+ �� 	Converter# [   �� ElementName$ StudentsListView��.+�5G      �� $��SELECTED STUDENT:��6   '   !StudentsApp.Controls.EditProperty  5H      	   
HeaderText$	 	Last Name��6(   
   Value
 6?   �� *
LastName+$ TwoWay=�$ PropertyChanged=�  5I      $��	5,5,4.8,5q�5J      $	 
First Name��5K      
 5L      �� *	FirstName+$ TwoWay=�$ PropertyChanged=�  5M      $		 Age��6(   
 69   �� *Age+$ TwoWay=�$ PropertyChanged=�  5N      $ 	 Gender(Only Муж/Жен)��6(   
 6J   �� *Gender+$ TwoWay=�$ PropertyChanged=�5O      5P      �� 5Q   
   -   5         ��Name$ StudentsListView��5R      $
��Auto��5S      $��0,0,0.4,0.4q�5T      $��Stretch=�5U      $��Stretch=�5V       �� AlternationCount$ 2��5W      ��5X      �� *
Students+ �� SelectedItem 5Y      �� *SelectedStudent+.  (System.Windows.Interactivity.Interaction   Triggers 5Z      /  )System.Windows.Interactivity.EventTrigger  5[         	EventName$ SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5\      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   ��  �� Path$$ SelectedStudentsChangedCommand�   CommandParameter 6d   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType$ ListViewL�$ SelectedItems�5]       �� View 5_      �� 5`      .P�5a      ��  �� Width$
 Auto��5b      $��Id��5d       �� DisplayMemberBinding 5c      �� *Id+5d      �� 5e      $
 Auto��6%   $��Last Name/First Name��62    �� CellTemplate 5f      �� 5g      .R�5h   "   �� ��5i   &   `� 5j   *    �� StringFormat$ {1} {0}��67   .1�5k   .   �� $ 	FirstName�66   �� 5l   .   $ LastName�66   5m   +   5o   #   5p      5r      �� 5s      $
 Auto��5t      $	��Age��5v       5u      �� *Age+$ 
{0} лет��5v      �� 5w      $
 Auto��5x      $��Gender��5z       5y      �� *Gender+5z      5{      5}      5~      5      