   M S B A M L   `   `   `  ����K  GPharmacy_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Pharmacy_ProjectPharmacy_Project  5   	   +    %Pharmacy_Project.AddNewDeliveryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Pharmacy_Project     5   	     � Title$  New Delivery��5   	   $	��300��6   $	��300��6+   .��5	      � $��5q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Center=�6   $��Supplier ID:��6/   �� 5   
   $��Center=�6   $��Order Date:��6/   $��1��6B   �� 5   
   $��Center=�6   $��Arrival Date:��6/   $��2��6D   �� 5   
   $��Center=�6   $��Driver Name:��6/   $��3��6C   �� 5   
   $��Center=�6   $��Delivery Details:��6/   $��4��6H   �� 5!   
   -   5         ��Name$ 	SuppIDTbx��5!   "   $��1��6   $��5q�65   (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ OrderDateDtp��5"   0   $��1��6   $��5q�6%   $��1��6F     5#   
   -   5        $ ArrivDateDtp��5#   0   $��1��6   $��5q�6%   $��2��6F   �� 5$   
   -   5        $ DriverNameTbx��5$   -   $��1��6   $��5q�6"   $��3��6D   �� 5%   
   -   5        $ DelDetailsTbx��5%   ;   $��1��6   $��5q�6#   $��4��6.   $��3��6R   �� 5)   
   $��7��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5*      �� -   5        $	��Add��5*   +   $��5q�69   $	��100��6D   �� 5+      -   5        $��Cancel��5+   -   $��5q�6>   $	��100��6I   5,      5-      5.      