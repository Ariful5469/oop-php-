<?php
class User {
    public $name;

    public function __construct($name) {
        $this->name = $name;
        echo "User $name created.\n";
    }

    public function __destruct() {
        echo "User $this->name destroyed.\n";
    }
}

$user = new User("John");
?>
