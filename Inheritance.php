<?php
class ParentClass {
    public function greet() {
        echo "Hello from Parent\n";
    }
}

class ChildClass extends ParentClass {
    public function greet() {
        echo "Hello from Child\n";
    }
}

$child = new ChildClass();
$child->greet();
?>
