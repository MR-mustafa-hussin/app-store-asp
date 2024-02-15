<?php
function lang($phrase ){

static $lang = array(

    'Home'      => 'الرئيسية',
    'About'     => 'من نحن',
    'Drop Down' => 'قائمة رئيسية',
    

);
return $lang[$phrase];
}






