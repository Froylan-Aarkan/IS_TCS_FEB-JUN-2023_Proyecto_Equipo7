   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas(FrontEnd.Vistas.SeguimientoProblematicas  5   	   M    GFrontEnd.Vistas.SeguimientoProblematicas.RegistrarProblematicaAcademica   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:FrontEnd.Vistas.SeguimientoProblematicas     5   	     � Title$  Problematica Académica��5   	   $	��800��6(   $
��1280��65    � 
ResizeMode$ CanMinimize=�6B    � WindowStartupLocation$ CenterScreen=�6[   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $'��!Registrar Problematica Académica��6>   $	��Top=�6f   $��72(�6~   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   -   5         ��Name$ btnCancelar��5      $��1��6&   $��40��64   $	��200��6@   $��Cancelar��6L   $
��Left=�6_   $��990,594,0,0q�6z   $	��Top=�6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $ 
btnGuardar��5      $��1��6%   $��40��63   $	��200��6?   $��Guardar��6K   $
��Left=�6]   $��
90,594,0,0q�6x   $	��Top=�6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5         ��Name$ cbEstudiante��5      $
��Left=�6)   $��	90,60,0,0q�6D   $��1��6W   $	��Top=�6d   $	��450��6|   $��18(�6�   �� 5   
   -   5        $ cbCategoria��5      $
��Left=�6(   $��
740,60,0,0q�6C   $��1��6W   $	��Top=�6d   $	��450��6|   $��18(�6�   �� 5   
   -   5        $ cbExperienciaEducativa��5      $
��Left=�63   $��
89,160,0,0q�6N   $��1��6b   $	��Top=�6o   $	��450��6�   $��18(�6�   6�   �� 5   
   -   5         ��Name$ tbAcadémico��5      $
��Left=�6'   $��740,160,0,0q�6B   $��1��6W    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��450��6�   $��18(�6�   $��30��6�   ${�False��6�   �� 5   
   -   5        $ tbFecha��5      $
��Left=�6#   $	��140��6>   $��30��6J   $��
89,270,0,0q�6V   $��1��6j   $
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $��18(�6�   ${�False��6�   �� 5   
   $��Fecha��6   $
��Left=�6    $��
90,236,0,0q�6;   $��1��6O   $	��Top=�6\   $��18(�6t   �� 5   
   $��Descripción��6   $
��Left=�6&   $��
90,312,0,0q�6A   $��1��6U   $	��Top=�6b   $��18(�6z   �� 5   
   $��
Estudiante��6   $
��Left=�6%   $��	90,21,0,0q�6@   $��1��6S   $	��Top=�6`   $��18(�6x   �� 5   
   $��	Categoria��6   $
��Left=�6$   $��
740,26,0,0q�6?   $��1��6S   $	��Top=�6`   $��18(�6x   �� 5   
   $��Experiencia Educativa��6   $
��Left=�60   $��
90,126,0,0q�6K   $��1��6_   $	��Top=�6l   $��18(�6�   �� 5   
   $��
Académico��6   $
��Left=�6$   $��740,121,0,0q�6?   $��1��6T   $	��Top=�6a   $��18(�6y   �� 5   
   -   5         ��Name$! lbExperienciaEducativaError��5      $�� ��65   $
��Left=�6@   $��
90,190,0,0q�6[   $��1��6o   $	��Top=�6|   $��18(�6�   
���  ��6�   �� 5   
   -	   5        $ lbEstudianteError��5      $�� ��6+   $
��Left=�66   $��	89,90,0,0q�6Q   $��1��6d   $	��Top=�6q   $��18(�6�   
���  ��6�   �� 5   
   -
   5        $ lbCategoriaError��5      $�� ��6*   $
��Left=�65   $��
740,90,0,0q�6P   $��1��6d   $	��Top=�6q   $��18(�6�   
���  ��6�   �� 5    
   -   5        $ lbDescripcionError��5       $�� ��6,   $
��Left=�67   $��
94,536,0,0q�6R   $��1��6f   $	��Top=�6s   $��18(�6�   
���  ��6�   �� 5!   
   -   5        	 ��Name$	 tbIdRolAcademico��5!      $��Center=�6.   $��	0,709,0,0q�6K   $��1��6^   $
��Wrap=�6k   $	��Top=�6   ${�False��6�   $y�Hidden=�6�   �� 5"   
   -   5        $	 tbIdAcademico��5"      $
��Left=�6+   $��134,302,0,0q�6F   $��2��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Hidden=�6�   ${�False��6�   �� 5#   
   -   5        $ tbDescripcion��5#      $��Center=�6)   $��	0,351,0,0q�6F   $��1��6Y   $
 Wrap=�6f   $	��Top=�6z   $
��1101��6�   $��12(�6�   $	��180��6�   5%      5&      