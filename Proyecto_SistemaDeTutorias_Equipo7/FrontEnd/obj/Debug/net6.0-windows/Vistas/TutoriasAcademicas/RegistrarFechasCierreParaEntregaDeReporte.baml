   M S B A M L   `   `   `  ����C  ?FrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas"FrontEnd.Vistas.TutoriasAcademicas  5   	   R    LFrontEnd.Vistas.TutoriasAcademicas.RegistrarFechasCierreParaEntregaDeReporte   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:FrontEnd.Vistas.TutoriasAcademicas     5   	     � Title$6  0Registrar fechas de cierre para entrega - Fechas��5   	   $	��750��6B   $	��432��6O    � 
ResizeMode$ CanMinimize=�6[    � WindowStartupLocation$ CenterScreen=�6t   .��5	      � $��0,0,0,-6q�6   $��Center=�6   $	��432��6:   .+�5
   
   �� $��Numero de sesión:��6   $
��Left=�6,   $��	52,98,0,0q�6G   $	��Top=�6Z   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��
52,178,0,0q�6<   $	��Top=�6P   �� 5   
   $��Numero de sesión:��6   $
��Left=�6,   $��
52,258,0,0q�6G   $	��Top=�6[   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��
52,338,0,0q�6<   $	��Top=�6P   �� 5   
   $��Numero de sesión:��6   $
��Left=�6,   $��
52,418,0,0q�6G   $	��Top=�6[   �� 5   
   $��Fecha:��6   $
��Left=�6!   $��
52,498,0,0q�6<   $	��Top=�6P   �� 5   
   $��Periodo Escolar:��6   $
��Left=�6+   $��
52,578,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5         ��Name$ tbNumeroSesionTres��5      $��Center=�6.   $��	0,444,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��330��6�   $��3��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ tbNumeroSesionDos��5      $��Center=�6-   $��	0,284,0,0q�6J   $
 Wrap=�6]   $��2��6q   $	��Top=�6z   $	��330��6�   $
 True��6�   �� 5   
   -   5        $ tbNumeroSesionUno��5      $��Center=�6-   $��	0,124,0,0q�6J   $
 Wrap=�6]   $��1��6q   $	��Top=�6z   $	��330��6�   $
 True��6�   �� 5   
   -   5         ��Name$ btRegistrar��5      $��	Registrar��6&   $
��Left=�6:   $��
52,666,0,0q�6U   $	��Top=�6i   $��90��6�   ���	#FF005BAA���	#FF005BAA
�������6�   �� 5   
   -   5        $ 
btRegresar��5      $��Regresar��6%   $
��Left=�68   $��292,666,0,0q�6S   $	��Top=�6h    J� RenderTransformOrigin$ 0.081,0.453&�6�   $��90��6�   
���  ��
���  ��
�������6�   �� 5   
   -   5         ��Name$ 
lbFechaUno��5      $�� ��6$   $��Center=�6/   $��	0,222,0,0q�6L   $	��Top=�6_   
���  ��$	��326��6�   �� 5   
   -   5        $ 
lbFechaDos��5      $�� ��6$   $��Center=�6/   $��	0,382,0,0q�6L   $	��Top=�6_   
���  ��$	��326��6�   �� 5   
   -   5        $ lbFechaTres��5      $�� ��6%   $��Center=�60   $��	0,542,0,0q�6M   $	��Top=�6`   
���  ��$	��326��6�   �� 5   
   -	   5        	 ��Name$	 tbIdAcademico��5      $
��Left=�6+   $��	0,200,0,0q�6F   $��2��6Y   $
��Wrap=�6f   $	��Top=�6z   $y�Hidden=�6�   ${�False��6�   �� 5   
   -
   5        $ lbPeriodoEscolar��5      $�� ��6*   $��Center=�65   $��	0,626,0,0q�6R   $	��Top=�6e   
���  ��$	��326��6�   �� 5   
   -   5        $	 tbIdRolAcademico��5      $
��Left=�6.   $��	0,220,0,0q�6I   $��2��6\   $
��Wrap=�6i   $	��Top=�6}   $y�Hidden=�6�   �� 5   
   -   5        
 ��Name$
 cbPeriodoEscolar��5      $��Center=�6-   $��	0,604,0,0q�6J   $	��Top=�6]   $	��326��6u   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
tbFechaUno��5      $
��Left=�6)   $��
54,198,0,0q�6D   $	��Top=�6X   $	��328��6p     5   
   -   5        $ 
tbFechaDos��5      $��Center=�6)   $��Center=�6F   $	��328��6a     5   
   -   5        $ tbFechaTres��5      $��Center=�6*   $��	0,518,0,0q�6G   $	��Top=�6Z   $	��328��6r   �� 5    
   $��Registrar Fechas para��6   $��Center=�60   $��0,2,0,0q�6M   $	��Top=�6^   $��36(�6v   $��Trebuchet MS)�6�   ���	#FF005BAA6�   �� 5!   
   $��Entrega del Reporte��6   $��Center=�6.   $��0,41,0,0q�6K   $	��Top=�6]   $��36(�6u   $��Trebuchet MS)�6�   ���	#FF005BAA6�   5"      5#      