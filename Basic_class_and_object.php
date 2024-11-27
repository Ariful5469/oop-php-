<?php
class MyClass {
    public $name = "PHP OOP";

    public function display() {
        echo "This is " . $this->name;
    }
}

$obj = new MyClass();
$obj->display();
?>
