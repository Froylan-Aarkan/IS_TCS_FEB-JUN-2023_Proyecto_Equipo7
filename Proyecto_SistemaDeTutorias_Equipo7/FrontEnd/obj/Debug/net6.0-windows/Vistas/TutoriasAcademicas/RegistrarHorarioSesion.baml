   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas"FrontEnd.Vistas.TutoriasAcademicas  5   	   ?    9FrontEnd.Vistas.TutoriasAcademicas.RegistrarHorarioSesion   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas     5   	     � Title$  Horario Sesión��5   	   $	��470��6    $
��1280��6-    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ CanMinimize=�6_   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $"��Registrar Horario de sesión��6>   $	��Top=�6a   $��72(�6y   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   -   5         ��Name$ cbEstudiante��5      $
��Left=�6)   $��	90,60,0,0q�6D   $��1��6W   $	��Top=�6d   $	��500��6|   $��18(�6�   �� 5   
   $��
Estudiante��6   $
��Left=�6%   $��	90,21,0,0q�6@   $��1��6S   $	��Top=�6`   $��18(�6x   �� 5   
   -   5         ��Name$ tbFecha��5      $
��Left=�6#   $	��140��6>   $��30��6J   $��
686,60,0,0q�6V   $��1��6j    �� TextWrapping$
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $��18(�6�   ${�False��6�   �� 5   
   $��Fecha��6   $
��Left=�6    $��
686,21,0,0q�6;   $��1��6O   $	��Top=�6\   $��18(�6t   �� 5   
   -   5        $ tbSesion��5      $
��Left=�6$   $	��140��6?   $��30��6K   $��1050,60,0,0q�6W   $��1��6l   $
 Wrap=�6y   $�� ��6�   $	��Top=�6�   $��18(�6�   ${�False��6�   �� 5   
   $��Sesión��6   $
��Left=�6!   $��1050,26,0,0q�6<   $��1��6Q   $	��Top=�6^   $��18(�6v   �� 5   
   -   5         ��Name$ btnCancelar��5      $��1��6&   $��40��64   $	��200��6@   $��Cancelar��6L   $
��Left=�6_   $��990,252,0,0q�6z   $	��Top=�6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $ 
btnGuardar��5      $��1��6%   $��40��63   $	��200��6?   $��Guardar��6K   $
��Left=�6]   $��
90,252,0,0q�6x   $	��Top=�6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   $
��Hora��6   $
��Left=�6   $��
90,136,0,0q�6:   $��1��6N   $	��Top=�6[   $��18(�6s   �� 5   
   -   5        $ cbHora��5      $
��Left=�6#   $��
90,175,0,0q�6>   $��1��6R   $	��Top=�6_   $	��200��6w   $��18(�6�   �� 5   
   -   5         ��Name$ lbEstudianteError��5      $�� ��6+   $
��Left=�66   $��	90,93,0,0q�6Q   $��1��6d   $	��Top=�6q   $��18(�6�   
���  ��6�   �� 5   
   -   5        $ lbHoraError��5      $�� ��6%   $
��Left=�60   $��
90,205,0,0q�6K   $��1��6_   $	��Top=�6l   $��18(�6�   
���  ��6�   �� 5   
   -	   5        	 ��Name$	 tbIdRolAcademico��5      $
��Left=�6.   $��576,272,0,0q�6I   $��1��6^   $
��Wrap=�6k   $	��Top=�6   $y�Hidden=�6�   ${�False��6�   �� 5   
   -
   5        $	 tbIdSesionTutoria��5      $
��Left=�6/   $��809,272,0,0q�6J   $��1��6_   $
��Wrap=�6l   $	��Top=�6�   ${�False��6�   $y�Hidden=�6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6)   $��640,292,0,0q�6D   $��1��6Y   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $y�Hidden=�6�   $�� ��6�   5!      5"      