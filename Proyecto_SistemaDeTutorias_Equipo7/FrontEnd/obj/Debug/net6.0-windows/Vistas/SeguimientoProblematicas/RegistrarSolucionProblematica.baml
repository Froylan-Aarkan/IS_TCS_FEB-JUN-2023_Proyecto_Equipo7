   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas(FrontEnd.Vistas.SeguimientoProblematicas  5   	   L    FFrontEnd.Vistas.SeguimientoProblematicas.RegistrarSolucionProblematica   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas     5   	     � Title$%  Registrar Solucion Problematica��5   	   $	��800��61   $
��1280��6>    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ CanMinimize=�6p   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $)��#Registrar Solución a Problemática��6>   $	��Top=�6g   $��72(�6   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgProblematicasAcademicas��5      $��1��66      AutoGenerateColumns$ False��6C      CanUserAddRows$ False��6_   $��159,66,167,176q�6v      
IsReadOnly$
 True��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Fecha��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 64      
IsReadOnly$
 True��6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *fecha+6Z     5      $	 Descripcion��6%   $
 * 6:   $
 True��6d    6D   �� *descripcion+6d   5      �� 5   
   $Z��TSeleccione el enlace de la problemática académica que desea registrar la solución��6   $��1��6m   $
��Left=�6z   $��
159,35,0,0q�6�   $	��Top=�6�   $��18(�6�   �� 5   
   -   5         ��Name$ BtnRegresar��5      $��Regresar��6&   $��1��69   $
��Left=�6F   $��913,571,0,0q�6a   $	��Top=�6v   $��40��6�   $	��200��6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $ btnConsultar��5      $��	Consultar��6'   $��1��6;   $
��Left=�6H   $��159,571,0,0q�6c   $	��Top=�6x   $��40��6�   $	��200��6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5         ��Name$ tbIdRolAcademico��5      $
��Left=�6.   $��134,202,0,0q�6I   $��2��6^   $
��Wrap=�6k   $	��Top=�6   $y�Hidden=�6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6+   $��134,302,0,0q�6F   $��2��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Hidden=�6�   ${�False��6�   5      5      