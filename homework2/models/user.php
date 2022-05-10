<?php

class User
{

    private $conn;
    private $table_name = "Users";

    public $id;
    public $Name;
    public $City_id;

    public function __construct($db)
    {
        $this->conn = $db;
    }

    function get()
    {

        $query = "SELECT * FROM " . $this->table_name . " ORDER BY id DESC";

        $stmt = $this->conn->prepare($query);

        $stmt->execute();

        return $stmt;
    }

    function create()
    {

        $query = "INSERT INTO " . $this->table_name . " SET Name=:Name, City_id=:City_id";

        $stmt = $this->conn->prepare($query);

        $this->Name = htmlspecialchars(strip_tags($this->Name));
        $this->City_id = htmlspecialchars(strip_tags($this->City_id));

        $stmt->bindParam(":Name", $this->Name);
        $stmt->bindParam(":City_id", $this->City_id);

        if ($stmt->execute()) {
            return true;
        }

        return false;
    }

    function update(){

        $query = "UPDATE
                " . $this->table_name . "
            SET
                Name = :Name,
                City_id = :City_id
            WHERE
                id = :id";

        $stmt = $this->conn->prepare($query);

        $this->Name=htmlspecialchars(strip_tags($this->Name));
        $this->City_id=htmlspecialchars(strip_tags($this->City_id));
        $this->id=htmlspecialchars(strip_tags($this->id));


        $stmt->bindParam(':Name', $this->Name);
        $stmt->bindParam(':City_id', $this->City_id);
        $stmt->bindParam(':id', $this->id);

        if ($stmt->execute()) {
            return true;
        }

        return false;
    }

    function delete(){

        $query = "DELETE FROM " . $this->table_name . " WHERE id = ?";

        $stmt = $this->conn->prepare($query);

        $this->id=htmlspecialchars(strip_tags($this->id));

        $stmt->bindParam(1, $this->id);

        if ($stmt->execute()) {
            return true;
        }

        return false;
    }

    function search($keywords){

        $query = "SELECT * FROM " . $this->table_name . " WHERE Name LIKE ? OR City_id LIKE ? ORDER BY id DESC";

        $stmt = $this->conn->prepare($query);

        $keywords=htmlspecialchars(strip_tags($keywords));
        $keywords = "%{$keywords}%";

        $stmt->bindParam(1, $keywords);
        $stmt->bindParam(2, $keywords);
        $stmt->bindParam(3, $keywords);

        $stmt->execute();

        return $stmt;
    }

    public function readPaging($from_record_num, $records_per_page){

        $query = "SELECT * FROM  " . $this->table_name . " ORDER BY id DESC LIMIT ?,?";

        $stmt = $this->conn->prepare( $query );

        $stmt->bindParam(1, $from_record_num, PDO::PARAM_INT);
        $stmt->bindParam(2, $records_per_page, PDO::PARAM_INT);

        $stmt->execute();

        return $stmt;
    }
    public function count(){
        $query = "SELECT COUNT(*) as total_rows FROM " . $this->table_name . "";

        $stmt = $this->conn->prepare( $query );
        $stmt->execute();
        $row = $stmt->fetch(PDO::FETCH_ASSOC);

        return $row['total_rows'];
    }

}


