   M S B A M L   `   `   `  ????@  <IISAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IISAS.xaml_window.admin_asIISAS.xaml_window.admin_as  5   	   =    7IISAS.xaml_window.admin_as.Upravljanje_popustima_izmena   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:IISAS.xaml_window.admin_as     5   	     ? Title$  Popusti_voznje_izmena??5      $	??550??6&   $	??600??63    ? WindowStartupLocation$ CenterScreen=?6?   .??5	      ? ??5
   
   ?? 5       ?? ImageSource$m g/IISAS;component/xaml_window/obican_korisnik/Slidebooks Consulting _ Business & Consulting Toolkits.jpg??6    j? Stretch$ UniformToFill=?6?    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      $	??140 ?6   6-   ?? 5      $??* ?6   6+   ?? 5      $	??110 ?6   6-   ?? 5      $??* ?6   6+   ?? 5      $??* ?6   6+   ?? 5      $	??120 ?6   6-   .+?5   
   ?? $??0??6   $??2??6   $??4??6.   $??6??6B   ???	#FF1D3045$??3q?6k   $??20,10,20,60q?6?   ._?5      ?? $??0??6   $??5??6&    ?? Orientation$ Vertical=?6:   ??5       ?? 5!       ?? Color$ 	#FFE0E9F3??6&    ?? Opacity$	 0.9Q?68   5#      5$      ?? 5&   
   $??	Castellar)?6   $??2??6'   $??4??67   $??0,0,0,20q?6K   $??Center=?6]   $??Center=?6z   $??30(?6?   .??6?   Izmena popusta6?   ?? 5'   
   $ Vertical=?6   $??2??6,   $??0??6<   $??5??6I   $??
20, 70,0,0q?6]   $??6??6q   .+?5(      ?? $ 
Horizontal=?6   .+?5)      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Početna stanica:6\   ?? 5*      -   5        $??	lbPocetna??5*   6   $	??120??6   $??50,0,0,0q?6$   $??14(?6G   6X   5+      ?? 5,      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5-      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Krajnja stanica:6\   ?? 5.      -   5        $??	lbKrajnja??5.   6   $	??120??6   $??57,0,0,0q?6$   $??14(?6G   6X   5/      ?? 50      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?51      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Datum:6R   ?? 52      -   5        $??lbDatum??52   7   $	??120??6   $??	108,0,0,0q?6$   $??14(?6F   6W   53      ?? 54      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?55      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Polazno vreme:6Z   ?? 56      -   5        $??lbPolaznoVreme??56   6   $	??120??6   $??55,0,0,0q?6$   $??14(?6L   6]   57      ?? 58      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?59      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Dolazno vreme:6Z   ?? 5:      -   5        $??lbDolaznoVreme??5:   6   $	??120??6   $??54,0,0,0q?6$   $??14(?6L   6]   5;      ?? 5<      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5=      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   
Prevoznik:6V   ?? 5>      -   5        $??lbPrevoznik??5>   6   $	??120??6   $??88,0,0,0q?6$   $??14(?6I   6Z   5?      ?? 5@      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5A      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   
Autobus:6T   ?? 5B      -   5        $??	lbAutobus??5B   6   $	??120??6   $??98,0,0,0q?6$   $??14(?6G   6X   5C      ?? 5D      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5E      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Preko:6R   ?? 5F      -   5        $??lbPreko??5F   5   $??5??6   $??2??6%   $??	114,5,0,0q?6D   $??3??6W   $	??200??6k   5G      5H      ?? 5I      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5J      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Peron:6R   ?? 5K      -	   5        $??lbPeron??5K   7   $	??120??6   $??	114,0,0,0q?6$   $??14(?6F   .??6U   p6X   5L      ?? 5M      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5N      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Cena:6Q   ?? 5O      -
   5        $??lbCena??5O   7   $	??120??6   $??	120,0,0,0q?6$   $??14(?6E   .??6T   c6W   5P      ?? 5Q      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5R      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Popust povratna:6\   ?? 5S      -   5        $??
tbPovratna??5S   D   $	??120??6   $??25??6&   $??43,0,0,0q?62   $??14(?6V   6g   5T      ?? 5U      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5V      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Popust studentska:6^   ?? 5W      -   5        $??tbStudentska??5W   D   $	??120??6   $??25??6&   $??31,0,0,0q?62   $??14(?6X   6i   5X      ?? 5Y      $ 
Horizontal=?6   $??0,0,0,0q?62   .+?5Z      ?? $
??Bold"?6   $??30,0,0,0q?6*   $??14(?6<   .??6J   Popust penzionerska:6`   ?? 5[      -   5        $??tbPenzionerska??5[   D   $	??120??6   $??25??6&   $??16,0,0,0q?62   $??14(?6Z   6k   5\      5`      ?? 5a   
   $??5??6   $??3??6"   $??3??62   $ 
Horizontal=?6F   .+?5b      ?? -   5        $	??120??5b      $??40??6!   ???	#FFEDEDED
???   ?$??	0,10,11,0q?6W   $??15(?6j   ???	#FF4D4D4D$??1,1,2,2q?6?   .??5c      ?? $ 
Horizontal=?6   .+?5d      ?? $??20(?6   ???	#FFEDEDED
???   ?$??Segoe MDL2 Assets)?6T   $	????6s   $??0,0,0,0q?6?   6?   ?? 5e      
???   ?$??15(?6/   .??6=   Izmeni6E   5f      5g      ?? 5h      -   5        $	??120??5h      $??40??6!   ???	#FFEDEDED
???   ?$??	0,10,20,0q?6W   $??15(?6j   ???	#FF4D4D4D$??1,1,2,2q?6?   .??5i      ?? $ 
Horizontal=?6   .+?5j      ?? $??20(?6   ???	#FFEDEDED
???   ?$??Segoe MDL2 Assets)?6T   $	????6s   $??0,0,0,0q?6?   6?   ?? 5k      
???   ?$??15(?6/   .??6=   Izađi6D   5l      5m      5n      ?? 5q   
   $??5??6   $ 
Horizontal=?6"   .+?5r      ?? $??40??6   $??40??6    $??2,0,0,0q?6,   $??0??6=   ??5s      ?? 5t      $  rocketship-303591_1280.png??6!   $	 0.4Q?6J   5w      ?? 5x      $??SemiBold"?6   $??Center=?6*   $??20(?6E   $??	Castellar)?6S   ??5y      ?? 5z      $ Black??6&   $	 0.5Q?64   ??5|      ?? 5}      $ Transparent??6&   $	 0.3Q?6:   .??5~   $   RaKeta5      5?      5?      5?      