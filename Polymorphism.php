<?php
class Shape {
    public function draw() {
        echo "Drawing Shape\n";
    }
}

class Circle extends Shape {
    public function draw() {
        echo "Drawing Circle\n";
    }
}

class Square extends Shape {
    public function draw() {
        echo "Drawing Square\n";
    }
}

$shapes = [new Circle(), new Square()];
foreach ($shapes as $shape) {
    $shape->draw();
}
?>
