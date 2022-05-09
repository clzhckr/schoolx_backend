<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");


include_once '../config/database.php';
include_once '../models/user.php';

$database = new Database();
$db = $database->getConnection();

$user = new User($db);


$stmt = $user->get();
$num = $stmt->rowCount();

if ($num > 0) {

    $user_arr = array();
    $user_arr["records"] = array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {

        // извлекаем строку
        extract($row, 1);

       /* $user_item = array(
            "id" => $id,
            "Name" => $Name,
            "City_id" => $City_id,
        );*/

        $user_arr["records"][] = $row;
    }

    http_response_code(200);

    echo json_encode($user_arr, JSON_THROW_ON_ERROR);

} else {
    http_response_code(404);

    echo json_encode(["message" => "Запись не найдена."], JSON_THROW_ON_ERROR | JSON_UNESCAPED_UNICODE);
}