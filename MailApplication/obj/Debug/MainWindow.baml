   M S B A M L   `   `   `  ����J  FMailApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MailApplicationMailApplication  5   	        MailApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MailApplication     5   	     � Title$"  Send Message to your clients��5   	   $	��350��6/   $	��493��6<   $��10(�5	   	   $
��Bold"�6!    � Icon$7 1C:\Stuff\VideoRent\VideoRent\Resources\thebat.jpg��5
   	    � WindowStartupLocation$ CenterScreen=�5      .��5      � -   5         �Name$ gridMain��5       � ColumnDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5      �� $
��Left=�6   $	��100��68   ��5      �� 5       �� ImageSource 5      �� 5       �� 	UriSource$? 9file:///C:/Stuff/VideoRent/VideoRent/Resources/batman.jpg?�6&   5      .+�5      �� -   5         ��Name$ btnNew��5      $��	New Email��6%   $��90��69   $��25��6D   $��5,5,5,5q�6P   
����d�
������� �� TextAlignment$ Justify=�5!      $	��Top=�68   �� 5"      -   5        $ btnInbox��5"      $��Inbox��6'   $��90��67   $��25��6B   $��5,0,5,5q�6N   
����d�
�������$ Justify=�5$      $	��Top=�68   �� 5%      -   5        $ btnSent��5%      $
��Sent��6&   $��90��65   $��25��6@   $��5,0,5,5q�6L   
����d�
�������$ Justify=�5'      $	��Top=�68   5(      ]� 5)   
   $��1��6   $��2��6$   
���P��.+�5*       � -   5        	  �Name$	 	mainFrame��5*      
���P��6(   5+      �� 55   
   -   5        
 ��Name$
 
panelError��55       �� Orientation$ Vertical=�6*   $��1��56      $��2��6%   $��Bottom=�69   $��Center=�57      
�������$y�Hidden=�6I   .+�58      �� -   5         ��Name$ 	errorText��58      
���  ��6+   59      5;      5j      