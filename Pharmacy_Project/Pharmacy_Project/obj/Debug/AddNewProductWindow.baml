   M S B A M L   `   `   `  ����K  GPharmacy_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Pharmacy_ProjectPharmacy_Project  5   	   *    $Pharmacy_Project.AddNewProductWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Pharmacy_Project     5   	     � Title$  New Product��5   	   $	��300��6   $	��300��6*   .��5	      � $��5q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Center=�6   $��Product Name:��6/   �� 5   
   $��Center=�6   $��Generic Name:��6/   $��1��6D   �� 5   
   $��Center=�6   $��Type:��6/   $��2��6<   �� 5   
   $��Center=�6   $��Form:��6/   $��3��6<   �� 5   
   $��Center=�6   $��Buying Price:��6/   $��4��6D   �� 5   
   $��Center=�6   $��Selling Price:��6/   $��5��6E   �� 5   
   $��Center=�6   $��	Quantity:��6/   $��6��6@   �� 5!   
   -   5         ��Name$ ProductNameTbx��5!      $��1��6*   $��5q�6:   �� 5"   
   -   5        $ GenericNameTbx��5"      $��1��6*   $��5q�6:   $��1��6E   �� 5#   
   -   5        $ TypeTbx��5#      $��1��6#   $��5q�63   $��2��6>   �� 5$   
   -   5        $ FormTbx��5$      $��1��6#   $��5q�63   $��3��6>   �� 5%   
   -   5        $ BuyingPriceTbx��5%      $��1��6*   $��5q�6:   $��4��6E   �� 5&   
   -   5        $ SellingPriceTbx��5&      $��1��6+   $��5q�6;   $��5��6F   �� 5'   
   -   5        $ 
QuanityTbx��5'      $��1��6&   $��5q�66   $��6��6A   �� 5)   
   $��7��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5*      �� -   5        $	��Add��5*   *   $��5q�68   $	��100��6C   �� 5+      -	   5        $��Cancel��5+   ,   $��5q�6=   $	��100��6H   5,      5-      5.      