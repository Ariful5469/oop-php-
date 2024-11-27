<?php
namespace App\Models;

class User {
    public function show() {
        echo "User from Models Namespace\n";
    }
}

$user = new \App\Models\User();
$user->show();
?>
