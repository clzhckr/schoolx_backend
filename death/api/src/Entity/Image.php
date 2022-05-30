<?php

namespace App\Entity;

use ApiPlatform\Core\Annotation\ApiFilter;
use ApiPlatform\Core\Annotation\ApiResource;
use ApiPlatform\Core\Bridge\Doctrine\Orm\Filter\DateFilter;
use ApiPlatform\Core\Bridge\Doctrine\Orm\Filter\OrderFilter;
use ApiPlatform\Core\Bridge\Doctrine\Orm\Filter\SearchFilter;
use App\Repository\ImageRepository;
use Doctrine\ORM\Mapping as ORM;

#[ORM\Entity(repositoryClass: ImageRepository::class)]
#[ApiResource(itemOperations: ['get', 'patch','delete'])]
#[ApiFilter(SearchFilter::class, properties: ['id' => 'exact'])]
#[ApiFilter(DateFilter::class, properties: ['date_create' => DateFilter::EXCLUDE_NULL])]
#[ApiFilter(OrderFilter::class, properties: ['id', 'date_create'])]
class Image
{
    #[ORM\Id]
    #[ORM\GeneratedValue]
    #[ORM\Column(type: 'integer')]
    private $id;

    #[ORM\Column(type: 'string', length: 255)]
    private $name;

    #[ORM\Column(type: 'string', length: 255)]
    private $size;

    #[ORM\Column(type: 'integer')]
    private $file;

    #[ORM\Column(type: 'integer')]
    private $parent;

    #[ORM\Column(type: 'integer')]
    private $child;

    #[ORM\Column(type: 'date')]
    public $date_create;

    #[ORM\Column(type: 'date')]
    public $date_update;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getName(): ?string
    {
        return $this->name;
    }

    public function setName(string $name): self
    {
        $this->name = $name;

        return $this;
    }

    public function getSize(): ?string
    {
        return $this->size;
    }

    public function setSize(string $size): self
    {
        $this->size = $size;

        return $this;
    }

    public function getFileId(): ?int
    {
        return $this->file;
    }

    public function setFileId(int $file): self
    {
        $this->file = $file;

        return $this;
    }

    public function getParentId(): ?int
    {
        return $this->parent;
    }

    public function setParentId(int $parent): self
    {
        $this->parent = $parent;

        return $this;
    }

    public function getChildId(): ?int
    {
        return $this->child;
    }

    public function setChildId(int $child): self
    {
        $this->child = $child;

        return $this;
    }
}
