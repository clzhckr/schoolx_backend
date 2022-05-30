<?php

declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20220530074945 extends AbstractMigration
{
    public function getDescription(): string
    {
        return '';
    }

    public function up(Schema $schema): void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->addSql('DROP TABLE base');
        $this->addSql('ALTER TABLE file DROP date_create, DROP date_update');
        $this->addSql('ALTER TABLE image ADD parent_id INT NOT NULL, ADD child_id INT NOT NULL, DROP date_create, DROP date_update, DROP parent, DROP child');
        $this->addSql('ALTER TABLE user CHANGE name name INT NOT NULL, CHANGE date_create date_create DATETIME NOT NULL, CHANGE date_update date_update DATETIME NOT NULL');
        $this->addSql('ALTER TABLE user_favorite ADD date_create DATETIME NOT NULL, ADD date_update DATETIME NOT NULL');
    }

    public function down(Schema $schema): void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->addSql('CREATE TABLE base (id INT AUTO_INCREMENT NOT NULL, date_create DATETIME NOT NULL, date_update DATETIME NOT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE `utf8mb4_unicode_ci` ENGINE = InnoDB COMMENT = \'\' ');
        $this->addSql('ALTER TABLE file ADD date_create DATE NOT NULL, ADD date_update DATE NOT NULL');
        $this->addSql('ALTER TABLE image ADD date_create DATETIME NOT NULL, ADD date_update DATETIME NOT NULL, ADD parent INT NOT NULL, ADD child INT NOT NULL, DROP parent_id, DROP child_id');
        $this->addSql('ALTER TABLE user CHANGE name name VARCHAR(255) CHARACTER SET utf8mb4 NOT NULL COLLATE `utf8mb4_unicode_ci`, CHANGE date_create date_create DATE NOT NULL, CHANGE date_update date_update DATE NOT NULL');
        $this->addSql('ALTER TABLE user_favorite DROP date_create, DROP date_update');
    }
}
