   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas(FrontEnd.Vistas.SeguimientoProblematicas  5   	   C    =FrontEnd.Vistas.SeguimientoProblematicas.SolucionProblematica   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas     5   	     � Title$%  Registrar Solucion Problematica��5   	   $	��800��61   $
��1280��6>    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ CanMinimize=�6p   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $)��#Registrar Solución a Problemática��6>   $	��Top=�6g   $��72(�6   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   $&�� Experiencia Educativa y Profesor��6   $��1��6;   $��Center=�6H   $��0,16,0,0q�6e   $	��Top=�6w   $��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5         ��Name$$ lbExperienciaEducativaProfesor��5      $��1��68   $�� ��6E   $��Center=�6P   $��0,55,0,0q�6m   $	��Top=�6   $��18(�6�   $	��562��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ tbDescripción��5      $��1��6+   $
��Left=�68   $��212,118,0,0q�6S   $
��Wrap=�6h   $	��Top=�6|   $	��110��6�   $	��969��6�   $�� ��6�   $��18(�6�   �� 5   
   $��Descripción:��6   $��1��6'   $
��Left=�64   $��101,113,0,0q�6O   $	��Top=�6d   $��18(�6|   �� 5   
   -   5         ��Name$ 
tbSolucion��5      $��1��6&   $
��Left=�63   $��101,273,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $
��1082��6�    J� RenderTransformOrigin$ 
0.456,0.54&�6�   $	��270��6�   �� 5   
   -   5        	 ��Name$	 btnCancelar��5      $��Cancelar��6&   $��1��69   $
��Left=�6F   $��101,592,0,0q�6a   $	��Top=�6v   $��40��6�   $	��200��6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $	 
btnGuardar��5      $��Guardar��6%   $��1��67   $
��Left=�6D   $��983,592,0,0q�6_   $	��Top=�6t   $��40��6�   $	��200��6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5        $ tbIdRolAcademico��5      $��Center=�6.   $��	0,709,0,0q�6K   $��1��6^   $
��Wrap=�6k   $	��Top=�6   ${�False��6�   $y�Hidden=�6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6+   $��134,302,0,0q�6F   $��2��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Hidden=�6�   ${�False��6�   �� 5   
   $,��&Escriba la solución a la problematica��6   $��1��6@   $
��Left=�6M   $��103,234,0,0q�6h   $	��Top=�6}   $��18(�6�   �� 5   
   $��Fecha��6   $��1��6    $
��Left=�6-   $��867,234,0,0q�6H   $	��Top=�6]   $��18(�6u   �� 5   
   -   5        $ tbFecha��5      $��1��6#   $
��Left=�60   $��928,238,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��255��6�   $��25��6�   ${�False��6�   $��18(�6�   �� 5   
   -	   5        $ lbErrorSolucion��5      $�� ��6)   $��1��64   $
��Left=�6A   $��103,543,0,0q�6\   $	��Top=�6q   ���	#FFF60B0B6�   �� 5   
   -
   5        $ tbIdProblematica��5      $
��Left=�6.   $��
77,451,0,0q�6I   $
��Wrap=�6]   $	��Top=�6q   
 � Cursor$
 AppStarting��6�   $y�Hidden=�6�   5      5       