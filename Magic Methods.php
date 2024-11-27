<?php
class Magic {
    private $data = [];

    public function __set($name, $value) {
        $this->data[$name] = $value;
    }

    public function __get($name) {
        return $this->data[$name] ?? null;
    }

    public function __toString() {
        return "Magic Class Instance\n";
    }
}

$obj = new Magic();
$obj->name = "OOP";
echo $obj->name;
echo $obj;
?>
