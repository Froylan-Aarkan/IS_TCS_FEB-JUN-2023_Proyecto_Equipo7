   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:FrontEnd.Vistas.AdministracionAcademica'FrontEnd.Vistas.AdministracionAcademica  5   	   E    ?FrontEnd.Vistas.AdministracionAcademica.AsignarTutorAEstudiante   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:FrontEnd.Vistas.AdministracionAcademica     5   	     � Title$  AsignarTutorAEstudiante��5   	   $	��800��6)   $
��1280��66    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ CanMinimize=�6h   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $ ��Asignar Tutor a Estudiante��6>   $	��Top=�6`   $��72(�6x   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   $`��ZPara cada estudiante, seleccione el tutor académico a asignar en el campo correspondiente��6   $��1��6t   $��Center=�6�   $��0,48,0,0q�6�   $	��Top=�6�   $	��652��6�   $��18(�6�   �� 5   
   $��Importante:��6   $��1��6&   $
��Left=�63   $��
342,87,0,0q�6N   $	��Top=�6b   $
��Bold"�6z   $��18(�6�   �� 5   
   $@��:Asigne un tutor académico a un estudiante para continuar.��6   $��1��6T   $
��Left=�6a   $��
453,87,0,0q�6|   $	��Top=�6�   $��18(�6�   �� 5   
   $k��eRecuerde que puede dejar sin asignar un tutor académico a uno o más estudiantes y hacerlo mas tarde��6   $��1��6~   $��Center=�6�   $��	0,126,0,0q�6�   $	��Top=�6�   $��18(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEstudiantes��5      $��1��6*      AutoGenerateColumns$ False��67      CanUserAddRows$ False��6S   $��216,192,216,237q�6j      
IsReadOnly$
 True��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Matricula��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 68      FontSize$ 18Q�6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	matricula+6b     5      $	 Nombre del estudiante��6%   $
 * 6D   $ 18Q�6q    6N   �� *nombreCompleto+6q   5      �� 5   
   -   5         ��Name$ 
BtnAceptar��5      $��Aceptar��6%   $��1��67   $
��Left=�6D   $��216,589,0,0q�6_   $	��Top=�6t   $��40��6�   $	��200��6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5        $ BtnCancelar��5      $��Regresar��6&   $��1��69   $
��Left=�6F   $��864,589,0,0q�6a   $	��Top=�6v   $��40��6�   $	��200��6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5         ��Name$ tbIdRolAcademico��5      $
��Left=�6.   $��
89,202,0,0q�6I   $��1��6]   $
��Wrap=�6j   $	��Top=�6~   $y�Hidden=�6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6+   $��134,302,0,0q�6F   $��1��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Hidden=�6�   ${�False��6�   �� 5   
   -   5         ��Name$ cbAcademicos��5      $��1��6)   $
��Left=�66   $��216,499,0,0q�6Q   $	��Top=�6f   $	��700��6~   $��18(�6�   �� 5    
   -   5         ��Name$ lblErrorTutores��5       $�� ��6)   $��1��65   $
��Left=�6B   $��227,529,0,0q�6]   $	��Top=�6r   ���	#FFEB0C0C$��18(�6�   �� 5!   
   -   5        $ lblErrorEstudiantes��5!      $�� ��6-   $��1��68   $
��Left=�6E   $��222,452,0,0q�6`   $	��Top=�6u   ���	#FFE20F0F$��18(�6�   5"      5#      