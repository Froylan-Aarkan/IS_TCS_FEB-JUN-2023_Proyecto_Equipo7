   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:FrontEnd.Vistas.AdministracionAcademica'FrontEnd.Vistas.AdministracionAcademica  5   	   @    :FrontEnd.Vistas.AdministracionAcademica.RegistrarAcademico   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:FrontEnd.Vistas.AdministracionAcademica     5   	     � Title$  
Académico��5   	   $	��720��6   $
��1280��6(    � 
ResizeMode$ CanMinimize=�65    � WindowStartupLocation$ CenterScreen=�6N   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $��Registrar Académico��6>   $	��Top=�6Y   $��72(�6q   $��Trebuchet MS)�6   ���	#FF005BAA$��0,6,0,0q�6�   �� 5   
   -   5         ��Name$ btnCancelar��5      $��1��6&   $��40��64   $	��200��6@   $��Cancelar��6L   $
��Left=�6_   $��990,500,0,0q�6z   $	��Top=�6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5        $ 
btnGuardar��5      $��1��6%   $��40��63   $	��200��6?   $��Guardar��6K   $
��Left=�6]   $��
90,500,0,0q�6x   $	��Top=�6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5         ��Name$ tbIdRolAcademico��5      $��Center=�6.   $��	0,520,0,0q�6K   $��1��6^   $
��Wrap=�6k   $	��Top=�6   $y�Hidden=�6�   ${�False��6�   �� 5   
   $��Nombre completo��6   $
��Left=�6*   $��	90,23,0,0q�6E   $��1��6X   $	��Top=�6e   $��18(�6}   �� 5   
   -   5         ��Name$ tbNombreCompleto��5      $
��Left=�6,   $��	90,62,0,0q�6G   $��1��6Z    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   $��Correo personal��6   $
��Left=�6*   $��
90,138,0,0q�6E   $��1��6Y   $	��Top=�6f   $��18(�6~   �� 5   
   -   5        $ tbCorreoPersonal��5      $
��Left=�6,   $��
90,177,0,0q�6G   $��1��6[   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   $��Correo institucional��6   $
��Left=�6/   $��690,138,0,0q�6J   $��1��6_   $	��Top=�6l   $��18(�6�   �� 5   
   -   5        $ tbCorreoInstitucional��5      $
��Left=�61   $��690,177,0,0q�6L   $��1��6a   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   $��Numero de personal��6   $
��Left=�6-   $��
90,248,0,0q�6H   $��1��6\   $	��Top=�6i   $��18(�6�   �� 5   
   -   5        $ tbNumeroPersonal��5      $
��Left=�6,   $��90,0,0,0q�6G   $��1��6Y   $
 Wrap=�6f   $�� ��6z   $��Center=�6�   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��
90,355,0,0q�6@   $��1��6T   $	��Top=�6a   $��18(�6y   G� 5   
   -   5         G�Name$ pbContrasenia��5      $
��Left=�6-   $��
90,394,0,0q�6H   $��1��6\   $	��Top=�6i   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   $��Rol Académico��6   $
��Left=�6(   $��690,355,0,0q�6C   $��1��6X   $	��Top=�6e   $��18(�6}   �� 5   
   -	   5        	 ��Name$	 cbRolAcademico��5      $
��Left=�6+   $��690,394,0,0q�6F   $��1��6[   $	��Top=�6h   $	��500��6�   $��30��6�   $��18(�6�   �� 5   
   -
   5        
 ��Name$
 lbNombreCompletoError��5      $�� ��6/   $
��Left=�6:   $��	90,92,0,0q�6U   $��1��6h   $	��Top=�6u   $��18(�6�   
���  ��6�   �� 5    
   -   5        $
 lbCorreoPersonalError��5       $�� ��6/   $
��Left=�6:   $��
90,207,0,0q�6U   $��1��6i   $	��Top=�6v   $��18(�6�   
���  ��6�   �� 5!   
   -   5        $ 
 lbCorreoInstitucionalError��5!      $�� ��64   $
��Left=�6?   $��690,207,0,0q�6Z   $��1��6o   $	��Top=�6|   $��18(�6�   
���  ��6�   �� 5"   
   -   5        $
 lbNumeroPersonalError��5"      $�� ��6/   $
��Left=�6:   $��
90,317,0,0q�6U   $��1��6i   $	��Top=�6v   $��18(�6�   
���  ��6�   �� 5#   
   -   5        $
 lbContraseniaError��5#      $�� ��6,   $
��Left=�67   $��
90,424,0,0q�6R   $��1��6f   $	��Top=�6s   $��18(�6�   
���  ��6�   �� 5$   
   -   5        $
 lbRolAcademicoError��5$      $�� ��6-   $
��Left=�68   $��694,424,0,0q�6S   $��1��6h   $	��Top=�6u   $��18(�6�   
���  ��6�   �� 5%   
   -   5        $ tbIdAcademico��5%      $
��Left=�6+   $��134,302,0,0q�6F   $��2��6[   $
��Wrap=�6h   $	��Top=�6|   $y�Hidden=�6�   ${�False��6�   5'      5(      