<?php
class User {
    private $name;

    public function setName($name) {
        $this->name = $name;
    }

    public function getName() {
        return $this->name;
    }
}

$user = new User();
$user->setName("Alice");
echo $user->getName();
?>