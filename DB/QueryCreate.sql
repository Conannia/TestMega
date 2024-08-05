sebelum membuat table form, migrasi terlebih dahulu semua scafold item melalui nuget console dengan comand berikut

Add-Migration InitialCreate
Update-Database

-- Membuat tabel ms_storage_location untuk menyimpan data lokasi penyimpanan
CREATE TABLE ms_storage_location (
    location_id VARCHAR(10) PRIMARY KEY,
    location_name VARCHAR(100) NOT NULL
);

-- Membuat tabel ms_user untuk menyimpan data pengguna untuk keperluan login
CREATE TABLE ms_user (
    user_id BIGINT PRIMARY KEY,
    user_name VARCHAR(20) NOT NULL,
    password VARCHAR(50) NOT NULL,
    is_active BIT NOT NULL
);

-- Membuat tabel tr_bpkb untuk menyimpan data transaksi
CREATE TABLE tr_bpkb (
    agreement_number VARCHAR(100) PRIMARY KEY,
    bpkb_no VARCHAR(100),
    branch_id VARCHAR(10),
    bpkb_date DATETIME,
    faktur_no VARCHAR(100),
    faktur_date DATETIME,
    location_id VARCHAR(10),
    police_no VARCHAR(20),
    bpkb_date_in DATETIME,
    created_by VARCHAR(20),
    created_on DATETIME,
    last_updated_by VARCHAR(20),
    last_updated_on DATETIME,
    FOREIGN KEY (location_id) REFERENCES ms_storage_location(location_id)
);
