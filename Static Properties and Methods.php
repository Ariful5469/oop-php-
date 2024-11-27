<?php
class StaticExample {
    public static $count = 0;

    public static function increment() {
        self::$count++;
        echo "Count: " . self::$count . "\n";
    }
}

StaticExample::increment();
StaticExample::increment();
?>
