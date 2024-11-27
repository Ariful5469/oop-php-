<?php
class CustomException extends Exception {}

try {
    throw new CustomException("Custom error occurred");
} catch (CustomException $e) {
    echo $e->getMessage();
}
?>
