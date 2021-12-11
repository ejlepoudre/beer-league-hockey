
resource "azurerm_mssql_firewall_rule" "example" {
  name             = "Abc Home"
  server_id        = azurerm_mssql_server.db.id
  start_ip_address = "73.144.140.201"
  end_ip_address   = "73.144.140.201"
}