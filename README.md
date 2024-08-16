
# Priority Queue Application

## Overview

This application is a Windows Forms project that demonstrates the use of a priority queue data structure to manage students. Students are added to the queue based on their academic performance and other criteria, and can be removed in priority order. The application allows you to add students to the queue, display the queue, and remove students from the queue. It also includes functionality for sorting the queue using heap sort.

## Features

- **Add Student**: Input student details including ID, name, GPA, absenteeism, and community service status, and add them to the priority queue.
- **Remove Student**: Remove the student with the highest priority from the queue and display their details.
- **Show Queue**: Display the current state of the priority queue in a list.
- **Heap Sort**: Sort the queue based on GPA using heap sort algorithm.

## Classes

### `Form1`

- **Events**:
  - `KuyrugaEkle_Click_1`: Adds a student to the priority queue.
  - `KuyruktanCikar_Click`: Removes the student with the highest priority from the queue and displays their details.
  - `KuyruguGoster_Click`: Displays the current state of the priority queue.

### `OncelikliKuyruk`

- **Methods**:
  - `OgrenciEkle(Ogrenci ogrenci)`: Adds a student to the queue with priority based on GPA, absenteeism, and community service.
  - `OgrenciCikar()`: Removes and returns the student with the highest priority.
  - `GosterListe()`: Returns a list of student details in the current queue.
  - `HeapSort(ListBox listBox)`: Sorts the queue using heap sort algorithm and displays the sorted list in the provided `ListBox`.

### `Ogrenci`

- **Properties**:
  - `No`: Student ID
  - `AdSoyad`: Student Name
  - `DiplomaNotu`: GPA
  - `Devamsizlik`: Absenteeism
  - `ToplulukGorevi`: Community Service Status

## How to Use

1. **Add Student**: Fill in the student details in the form and click the "Add" button to add the student to the queue.
2. **Remove Student**: Click the "Remove" button to remove the student with the highest priority from the queue.
3. **Show Queue**: Click the "Show Queue" button to display the current queue state.
4. **Heap Sort**: The queue can be sorted using the heap sort algorithm by calling the `HeapSort` method.

## Requirements

- .NET Framework
- Windows Forms

## License

This project is licensed under the MIT License.

---

# Öncelikli Kuyruk Uygulaması

## Genel Bakış

Bu uygulama, Windows Forms projesidir ve öğrenci yönetimi için öncelikli kuyruk veri yapısının kullanımını gösterir. Öğrenciler, akademik performans ve diğer kriterlere göre kuyruğa eklenir ve öncelik sırasına göre çıkarılabilirler. Uygulama, öğrenci eklemeyi, kuyruğu görüntülemeyi ve öğrencileri kuyruktan çıkarmayı sağlar. Ayrıca, kuyruğu heap sıralama algoritması kullanarak sıralama işlevi de içerir.

## Özellikler

- **Öğrenci Ekle**: Öğrenci bilgilerini (ID, ad, soyad, GPA, devamsızlık ve topluluk hizmeti durumu) girerek öncelikli kuyruğa ekleyin.
- **Öğrenci Çıkar**: Kuyruktaki en yüksek önceliğe sahip öğrenciyi çıkarın ve bilgilerini görüntüleyin.
- **Kuyruğu Göster**: Öncelikli kuyruğun mevcut durumunu bir listede görüntüleyin.
- **Heap Sıralama**: GPA'ya göre kuyruğu heap sıralama algoritması kullanarak sıralayın.

## Sınıflar

### `Form1`

- **Olaylar**:
  - `KuyrugaEkle_Click_1`: Öğrenciyi öncelikli kuyruğa ekler.
  - `KuyruktanCikar_Click`: Kuyruktaki en yüksek önceliğe sahip öğrenciyi çıkarır ve bilgilerini görüntüler.
  - `KuyruguGoster_Click`: Öncelikli kuyruğun mevcut durumunu görüntüler.

### `OncelikliKuyruk`

- **Metodlar**:
  - `OgrenciEkle(Ogrenci ogrenci)`: Öğrenciyi GPA, devamsızlık ve topluluk hizmetine göre öncelikli kuyruğa ekler.
  - `OgrenciCikar()`: En yüksek önceliğe sahip öğrenciyi çıkarır ve döndürür.
  - `GosterListe()`: Mevcut kuyruktaki öğrenci bilgilerini içeren bir liste döndürür.
  - `HeapSort(ListBox listBox)`: Kuyruğu heap sıralama algoritması kullanarak sıralar ve sıralanmış listeyi verilen `ListBox` içinde görüntüler.

### `Ogrenci`

- **Özellikler**:
  - `No`: Öğrenci ID'si
  - `AdSoyad`: Öğrenci Adı
  - `DiplomaNotu`: GPA
  - `Devamsizlik`: Devamsızlık
  - `ToplulukGorevi`: Topluluk Hizmeti Durumu

## Kullanım

1. **Öğrenci Ekle**: Formdaki öğrenci bilgilerini doldurun ve öğrenci kuyruğa eklemek için "Ekle" butonuna tıklayın.
2. **Öğrenci Çıkar**: Kuyruktaki en yüksek önceliğe sahip öğrenciyi çıkarmak için "Çıkar" butonuna tıklayın.
3. **Kuyruğu Göster**: Mevcut kuyruk durumunu görüntülemek için "Kuyruğu Göster" butonuna tıklayın.
4. **Heap Sıralama**: Kuyruğu heap sıralama algoritması kullanarak sıralamak için `HeapSort` metodunu çağırın.

## Gereksinimler

- .NET Framework
- Windows Forms
