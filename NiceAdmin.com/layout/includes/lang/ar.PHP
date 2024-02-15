<?php
function lang($phrase ){

static $lang = array(

    'MESSAGE' => 'اهلا وسهلا بكم فى عالم الطبيعة المستجد',
    'ADMIN' => 'مدير الادارة'
);
return $lang[$phrase];
}
