variable "resource_group_name" {
  default = "rg-beer-league-hockey-app"
}

variable "location" {
  default ="eastus"
}

variable "sql-login" {
  type = string
}

variable "sql-password" {
  type = string
}

variable "sql-threat-email" {
  type = string
}
