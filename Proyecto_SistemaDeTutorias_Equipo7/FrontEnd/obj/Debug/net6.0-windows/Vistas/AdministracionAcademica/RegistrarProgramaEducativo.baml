   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:FrontEnd.Vistas.AdministracionAcademica'FrontEnd.Vistas.AdministracionAcademica  5   	   H    BFrontEnd.Vistas.AdministracionAcademica.RegistrarProgramaEducativo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:FrontEnd.Vistas.AdministracionAcademica     5   	     � Title$   RegistrarProgramaEducativo��5   	   $	��370��6,   $	��800��69    � 
ResizeMode$ CanMinimize=�6E    � WindowStartupLocation$ CenterScreen=�6^   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $"��Registrar Programa Educativo��6>   $	��Top=�6b   $��48(�6z   $��Trebuchet MS)�6�   ���	#FF005BAA$��0,20,0,0q�6�   �� 5   
   $$��Nombre del programa educativo:��6   $��1��69   $
��Left=�6F   $��51,6,0,0q�6a   $	��Top=�6s   $��18(�6�   �� 5   
   -   5         ��Name$ BtnRegistrar��5      $��	Registrar��6'   $��1��6;   $��Right=�6H   $��0,165,537,0q�6e   $	��Top=�6z   $��40��6�   $	��200��6�   ���	#FF005BAA
�������$��18(�6�   ���	#FF005BAA6�   �� 5   
   -   5        $ BtnCancelar��5      $��Cancelar��6&   $��1��69   $��Right=�6F   $��
0,165,39,0q�6b   $	��Top=�6v   $��40��6�   $	��200��6�   
���  ��
�������$��18(�6�   
���  ��6�   �� 5   
   -   5         ��Name$ tbIdRolAcademico��5      $
��Left=�6.   $��
89,202,0,0q�6I   $��2��6]   $
��Wrap=�6j   $	��Top=�6~   $y�Hidden=�6�   �� 5   
   -   5        $ tbIdAcademico��5      $
��Left=�6,   $��134,302,0,0q�6G   $��2��6\   $
��Wrap=�6i   $	��Top=�6}   $y�Hidden=�6�   ${�False��6�   �� 5   
   -   5         ��Name$ tbProgramaEducativo��5      $��1��6/   $��Center=�6<   $��0,45,0,0q�6Y    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��698��6�   $��18(�6�   �� 5   
   -   5         ��Name$ lbProgramaEducativoError��5      $�� ��62   $
��Left=�6=   $��	63,76,0,0q�6X   $��1��6k   $	��Top=�6x   $��18(�6�   
���  ��6�   5      5      