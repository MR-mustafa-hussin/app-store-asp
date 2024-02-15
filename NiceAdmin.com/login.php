    <?php
    include 'connect.php';
    include 'int.php' ;
    include  $tpl.'header.php';
    include  $lang.'en.php';
//دالة تستخدم فى ثلاث نقط مهمة جداا

    ?>
            <form class="login" action= method="post">
                <img src="<?php echo $IMG;  ?>22 (38).png" alt="user">
                <h2 class="text-center">login </h2>
                <input class="form-control"  type="text" name="user" placeholder="UserName" autocomplete="off">
                <input class="form-control"  type="password" name="pass" placeholder="password" autocomplete="new password">
                <input class="btn btn-primary btn-block"type="submit" value="login">
                <p>اعادة كلمة المرور</p>
            </form>

    <?php include  $tpl. 'footer.php';

    ?>