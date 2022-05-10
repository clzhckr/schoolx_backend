<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

include_once '../config/config.php';
include_once '../shared/utilities.php';
include_once '../config/database.php';
include_once '../models/user.php';

$utilities = new Utilities();
$database = new Database();
$db = $database->getConnection();
$user = new user($db);

$stmt = $user->readPaging($from_record_num, $records_per_page);
$num = $stmt->rowCount();

if ($num>0) {

    $users_arr=array();
    $users_arr["records"]=array();
    $users_arr["paging"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        extract($row, 1);
        $user_arr["records"][] = $row;
    }
    
    $total_rows=$user->count();
    $page_url="{$home_url}user/get_with_pagination.php?";
    $paging=$utilities->getPaging($page, $total_rows, $records_per_page, $page_url);
    $users_arr["paging"]=$paging;
    
    http_response_code(200);
    
    echo json_encode($users_arr);

} else {
    
    http_response_code(404);
    
    echo json_encode(array("message" => "Записи не найдены."), JSON_UNESCAPED_UNICODE);
}
?>