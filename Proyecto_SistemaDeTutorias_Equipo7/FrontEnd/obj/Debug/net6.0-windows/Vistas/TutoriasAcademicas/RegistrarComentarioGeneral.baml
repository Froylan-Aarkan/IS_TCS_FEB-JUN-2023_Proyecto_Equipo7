   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas"FrontEnd.Vistas.TutoriasAcademicas  5   	   C    =FrontEnd.Vistas.TutoriasAcademicas.RegistrarComentarioGeneral   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas     5   	     � Title$  Comentario General��5   	   $	��720��6$   $
��1280��61    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ CanMinimize=�6c   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $"��Registrar Comentario General��6>   $	��Top=�6b   $��72(�6z   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   -   5         ��Name$ btnCancelar��5      $��1��6&   $��40��64   $	��200��6@   $��Cancelar��6L   $��Center=�6_   $��900,500,0,0q�6|   $	��Top=�6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $ 
btnGuardar��5      $��1��6%   $��40��63   $	��200��6?   $��Guardar��6K   $��Center=�6]   $��-900,500,0,0q�6z   $	��Top=�6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5         ��Name$ tbFecha��5      $
��Left=�6#   $	��140��6>   $��30��6J   $��	90,57,0,0q�6V   $��1��6i    �� TextWrapping$
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $��18(�6�   ${�False��6�   �� 5   
   $��Fecha��6   $
��Left=�6    $��	90,23,0,0q�6;   $��1��6N   $	��Top=�6[   $��18(�6s   �� 5   
   $��Descripción��6   $
��Left=�6&   $��
90,125,0,0q�6A   $��1��6U   $	��Top=�6b   $��18(�6z   �� 5   
   -   5        $ tbDescripcion��5      $��Center=�6)   $��	0,165,0,0q�6F   $��1��6Y   $
 Wrap=�6f   $	��Top=�6z   $
��1100��6�   $	��293��6�   $��18(�6�   �� 5   
   -   5         ��Name$ tbIdRolAcademico��5      $
��Left=�6.   $��
523,40,0,0q�6I   $��1��6]   $
��Wrap=�6j   $	��Top=�6~   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ lbDescripcionError��5      $�� ��6,   $
��Left=�67   $��
90,458,0,0q�6R   $��1��6f   $	��Top=�6s   $��18(�6�   
���  ��6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6+   $��241,569,0,0q�6F   $��2��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Visible=�6�   ${�False��6�   5      5      