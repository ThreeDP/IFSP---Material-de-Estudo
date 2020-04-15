# Comandos Mais usados
### Gerenciamento de pacotes

    apt show nome_pacote
> Mostra detalhes do pacote escolhido.

### Manipulação em diretorios

    cd  /
> Abre o diretorio raiz

    mkdir nome_diretorio
> Cria um diretorio

    rmdir
> Exclui o diretorio

    rm --help
> Busca o dicionario de comandos rm.

    touch nome.txt // Exemplo.
> Cria um arquivo com a extenção desejada

    ls
> Lista os arquivos da pasta onde se está

    ls -s
> Lista os arquivos da pasta e seus respectivos tamanhos.

    ls --help
> Busca o discionario de comandos com ls.

    ls -l
> Trás mais detalhes dos arquivos da pasta.

    pwd
> Mostra o nome do caminho de diretorio atual

# Utilidades
### Para manipular diretorios e arquivos

**Para listar arquivos:**

    ls -l arq*
> Lista todos os arquivos que comecem com arq como no exemplo e tenha qualquer coisa no restante.

    ls -l arq[1-b]*
> Lista todos os arquivos que comecem com arq tenha qualquer letra ou numero de 1 á b e completem com qualquer outra coisa.

    ls -l arq*.t*
> Lista todos os arquivos que comecem com arq e termine com qualquer coisa e que a extenção comece com t e termine com qualquer coisa.
 
    ls -l arq*.?x?
> Lista todos os arquivos que comecem com arq e termine com qualquer coisa e que a extenção tenha 1 caracter depois venha x depois qualquer caracter. Cada interogação representa um caracter de qualque tipo se houvesse ??x? a extenção seria dois caracteres de qualquer tipo no inicio e no final o caracter de qualquer tipo.
 
    rm -rf arq*
> Remove todos os arquivos que se inicie com arq.

    rm -rf arq *
> remove todos os arquivos que se inicie com arq e todos os arquivos da pasta.

    unset history.file
> Desabilita o historio de comandos do terminal.

    cat /root/.bash_history
> Pega e visualiza o historico de comandos usados no terminal.




root@debian:/tmp/ifsp# unset history file
root@debian:/tmp/ifsp# set AA = blablabla
root@debian:/tmp/ifsp# echo $AA

root@debian:/tmp/ifsp# unset history.file
-bash: unset: `history.file': not a valid identifier
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# echo hystory
hystory
root@debian:/tmp/ifsp# echo $hystory

root@debian:/tmp/ifsp# echo $history

root@debian:/tmp/ifsp# echo $history.file
.file
root@debian:/tmp/ifsp# cat /root/.bash_history
-su
su
exit
exit
sudo apt-get install x3270
ls
ls
clear
ls -la
cd .profile
clear
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
nano /etc/apt/sources.list
apt-get update
apt update
nano /etc/apt/sources.list
apt update
nano /etc/apt/sources.list
apt update
clear
apt install mc
apt install x3270
x3270
clear
apt search
apt search game
apt search x3270
apt show x3270
x3270
clear
ifconfig
ifconfig
ifconfig
sudo ifconfig
exi
ip addr
apt install net-tools
ifconfig
clear
clear
clear
clear
ifconfig wlan0
apt search wlan
ifconfig
ifsonfig enp0s3
ifsonfig enp
ifsonfig enp0
ifsonfig l0
ifsonfig -a
ifconfig -a
ifconfig enp0s3
hostname
hostname tiozao
hostname
cat /etc/resolv.conf
nameserver 8.8.8.8
clear
cat /etc/resolv.conf
vim /etc/resolv.conf
nano /etc/resolv.conf
route
ssh z53907@192.86.32.67
apt install npm
npm i -g @zowe/cli@latest --ignore-scripts
zowe profiles create zosmf-profile --help
clear
zowe zosmf check status
apt search vs
ls
cd /
ls
cd /homr
cd /home
ls
cd threedp
cd
ls
cd /home/threedp/Downloads
ls
dpkg -i code_1.42.1-1581432938_amd64.deb 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv /etc/apt/arq.txt .
mv: cannot stat '/etc/apt/arq.txt': No such file or directory
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv arq.txt arq0.txt
mv: cannot stat 'arq.txt': No such file or directory
root@debian:/tmp/ifsp# mkdir arq.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# mv arq.txt arq0.txt
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# free -h
              total        used        free      shared  buff/cache   available
Mem:          1.9Gi       1.0Gi       176Mi        62Mi       757Mi       712Mi
Swap:         2.0Gi       5.0Mi       2.0Gi
root@debian:/tmp/ifsp# free
              total        used        free      shared  buff/cache   available
Mem:        2043248     1086468      181144       63548      775636      729244
Swap:       2095100        5900     2089200
root@debian:/tmp/ifsp# df -h
Filesystem      Size  Used Avail Use% Mounted on
udev            979M     0  979M   0% /dev
tmpfs           200M  6.1M  194M   4% /run
/dev/sda1        18G  5.8G   11G  35% /
tmpfs           998M   37M  961M   4% /dev/shm
tmpfs           5.0M  4.0K  5.0M   1% /run/lock
tmpfs           998M     0  998M   0% /sys/fs/cgroup
tmpfs           200M  8.6M  191M   5% /run/user/1000
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# 
root@debian:/tmp/ifsp# df-h
-bash: df-h: command not found
root@debian:/tmp/ifsp# df -h
Filesystem      Size  Used Avail Use% Mounted on
udev            979M     0  979M   0% /dev
tmpfs           200M  6.1M  194M   4% /run
/dev/sda1        18G  5.8G   11G  35% /
tmpfs           998M   37M  961M   4% /dev/shm
tmpfs           5.0M  4.0K  5.0M   1% /run/lock
tmpfs           998M     0  998M   0% /sys/fs/cgroup
tmpfs           200M  8.6M  191M   5% /run/user/1000
root@debian:/tmp/ifsp#  cd /
root@debian:/# ls -la mnt/
total 8
drwxr-xr-x  2 root root 4096 Feb 12 20:47 .
drwxr-xr-x 19 root root 4096 Mar 11 19:55 ..
root@debian:/# mount ;de/sda3 /mnt/
sysfs on /sys type sysfs (rw,nosuid,nodev,noexec,relatime)
proc on /proc type proc (rw,nosuid,nodev,noexec,relatime)
udev on /dev type devtmpfs (rw,nosuid,relatime,size=1001796k,nr_inodes=250449,mode=755)
devpts on /dev/pts type devpts (rw,nosuid,noexec,relatime,gid=5,mode=620,ptmxmode=000)
tmpfs on /run type tmpfs (rw,nosuid,noexec,relatime,size=204328k,mode=755)
/dev/sda1 on / type ext4 (rw,relatime,errors=remount-ro)
securityfs on /sys/kernel/security type securityfs (rw,nosuid,nodev,noexec,relatime)
tmpfs on /dev/shm type tmpfs (rw,nosuid,nodev)
tmpfs on /run/lock type tmpfs (rw,nosuid,nodev,noexec,relatime,size=5120k)
tmpfs on /sys/fs/cgroup type tmpfs (ro,nosuid,nodev,noexec,mode=755)
cgroup2 on /sys/fs/cgroup/unified type cgroup2 (rw,nosuid,nodev,noexec,relatime,nsdelegate)
cgroup on /sys/fs/cgroup/systemd type cgroup (rw,nosuid,nodev,noexec,relatime,xattr,name=systemd)
pstore on /sys/fs/pstore type pstore (rw,nosuid,nodev,noexec,relatime)
bpf on /sys/fs/bpf type bpf (rw,nosuid,nodev,noexec,relatime,mode=700)
cgroup on /sys/fs/cgroup/pids type cgroup (rw,nosuid,nodev,noexec,relatime,pids)
cgroup on /sys/fs/cgroup/freezer type cgroup (rw,nosuid,nodev,noexec,relatime,freezer)
cgroup on /sys/fs/cgroup/cpu,cpuacct type cgroup (rw,nosuid,nodev,noexec,relatime,cpu,cpuacct)
cgroup on /sys/fs/cgroup/devices type cgroup (rw,nosuid,nodev,noexec,relatime,devices)
cgroup on /sys/fs/cgroup/perf_event type cgroup (rw,nosuid,nodev,noexec,relatime,perf_event)
cgroup on /sys/fs/cgroup/net_cls,net_prio type cgroup (rw,nosuid,nodev,noexec,relatime,net_cls,net_prio)
cgroup on /sys/fs/cgroup/rdma type cgroup (rw,nosuid,nodev,noexec,relatime,rdma)
cgroup on /sys/fs/cgroup/memory type cgroup (rw,nosuid,nodev,noexec,relatime,memory)
cgroup on /sys/fs/cgroup/cpuset type cgroup (rw,nosuid,nodev,noexec,relatime,cpuset)
cgroup on /sys/fs/cgroup/blkio type cgroup (rw,nosuid,nodev,noexec,relatime,blkio)
systemd-1 on /proc/sys/fs/binfmt_misc type autofs (rw,relatime,fd=41,pgrp=1,timeout=0,minproto=5,maxproto=5,direct,pipe_ino=10671)
debugfs on /sys/kernel/debug type debugfs (rw,relatime)
mqueue on /dev/mqueue type mqueue (rw,relatime)
hugetlbfs on /dev/hugepages type hugetlbfs (rw,relatime,pagesize=2M)
tmpfs on /run/user/1000 type tmpfs (rw,nosuid,nodev,relatime,size=204324k,mode=700,uid=1000,gid=1000)
gvfsd-fuse on /run/user/1000/gvfs type fuse.gvfsd-fuse (rw,nosuid,nodev,relatime,user_id=1000,group_id=1000)
fusectl on /sys/fs/fuse/connections type fusectl (rw,relatime)
-bash: de/sda3: No such file or directory
root@debian:/# mount /dev/sda3 /mnt/
mount: /mnt: special device /dev/sda3 does not exist.
root@debian:/# df -h
Filesystem      Size  Used Avail Use% Mounted on
udev            979M     0  979M   0% /dev
tmpfs           200M  6.1M  194M   4% /run
/dev/sda1        18G  5.8G   11G  35% /
tmpfs           998M   37M  961M   4% /dev/shm
tmpfs           5.0M  4.0K  5.0M   1% /run/lock
tmpfs           998M     0  998M   0% /sys/fs/cgroup
tmpfs           200M  8.6M  191M   5% /run/user/1000
root@debian:/# fdisk -f
fdisk: invalid option -- 'f'
Try 'fdisk --help' for more information.
root@debian:/# fdisk -l
Disk /dev/sda: 20 GiB, 21474836480 bytes, 41943040 sectors
Disk model: VBOX HARDDISK   
Units: sectors of 1 * 512 = 512 bytes
Sector size (logical/physical): 512 bytes / 512 bytes
I/O size (minimum/optimal): 512 bytes / 512 bytes
Disklabel type: dos
Disk identifier: 0x43df23da

Device     Boot    Start      End  Sectors Size Id Type
/dev/sda1  *        2048 37748735 37746688  18G 83 Linux
/dev/sda2       37750782 41940991  4190210   2G  5 Extended
/dev/sda5       37750784 41940991  4190208   2G 82 Linux swap / Solaris


root@debian:/# mount /dev/sda5 /mnt/
mount: /mnt: unknown filesystem type 'swap'.
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# top

top - 21:41:46 up  2:20,  1 user,  load average: 0.00, 0.00, 0.00
Tasks: 138 total,   4 running, 134 sleeping,   0 stopped,   0 zombie
%Cpu(s):  3.2 us,  0.0 sy,  0.0 ni, 96.8 id,  0.0 wa,  0.0 hi,  0.0 si,  0.0 st
MiB Mem :   1995.4 total,    171.2 free,   1046.5 used,    777.7 buff/cache
MiB Swap:   2046.0 total,   2040.5 free,      5.5 used.    726.5 avail Mem 

  PID USER      PR  NI    VIRT    RES    SHR S  %CPU  %MEM     TIME+ COMMAND    
  863 threedp   20   0 2562160 250792  98508 R   3.1  12.3   2:08.68 gnome-she+ 
    1 root      20   0  169580  10052   7916 S   0.0   0.5   0:01.40 systemd    
    2 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kthreadd   
    3 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_gp     
    4 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_par_gp 
    6 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 kworker/0+ 
    8 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 mm_percpu+ 
    9 root      20   0       0      0      0 S   0.0   0.0   0:00.13 ksoftirqd+ 
   10 root      20   0       0      0      0 I   0.0   0.0   0:00.44 rcu_sched  
   11 root      20   0       0      0      0 I   0.0   0.0   0:00.00 rcu_bh     
   12 root      rt   0       0      0      0 S   0.0   0.0   0:00.09 migration+ 
   14 root      20   0       0      0      0 S   0.0   0.0   0:00.00 cpuhp/0    
   15 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kdevtmpfs  
   16 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 netns      
   17 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kauditd    
   18 root      20   0       0      0      0 S   0.0   0.0   0:00.00 khungtaskd 
   19 root      20   0       0      0      0 S   0.0   0.0   0:00.00 oom_reaper 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# h top
-bash: h: command not found
root@debian:/# htop
-bash: htop: command not found
root@debian:/# top

top - 21:44:46 up  2:23,  1 user,  load average: 0.01, 0.01, 0.00
Tasks: 138 total,   1 running, 137 sleeping,   0 stopped,   0 zombie
%Cpu(s):  0.7 us,  0.0 sy,  0.0 ni, 99.3 id,  0.0 wa,  0.0 hi,  0.0 si,  0.0 st
%Node0 :  0.7 us,  0.0 sy,  0.0 ni, 99.3 id,  0.0 wa,  0.0 hi,  0.0 si,  0.0 st
MiB Mem :   1995.4 total,    172.6 free,   1045.0 used,    777.8 buff/cache
MiB Swap:   2046.0 total,   2040.5 free,      5.5 used.    728.0 avail Mem 

  PID USER      PR  NI    VIRT    RES    SHR S  %CPU  %MEM     TIME+ COMMAND    
  863 threedp   20   0 2562176 250880  98508 S   0.3  12.3   2:10.76 gnome-she+ 
    1 root      20   0  169580  10052   7916 S   0.0   0.5   0:01.40 systemd    
    2 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kthreadd   
    3 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_gp     
    4 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_par_gp 
    6 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 kworker/0+ 
    8 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 mm_percpu+ 
    9 root      20   0       0      0      0 S   0.0   0.0   0:00.13 ksoftirqd+ 
   10 root      20   0       0      0      0 I   0.0   0.0   0:00.44 rcu_sched  
   11 root      20   0       0      0      0 I   0.0   0.0   0:00.00 rcu_bh     
   12 root      rt   0       0      0      0 S   0.0   0.0   0:00.09 migration+ 
   14 root      20   0       0      0      0 S   0.0   0.0   0:00.00 cpuhp/0    
   15 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kdevtmpfs  
   16 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 netns      
   17 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kauditd    
   18 root      20   0       0      0      0 S   0.0   0.0   0:00.00 khungtaskd 
root@debian:/# 
root@debian:/# 
root@debian:/# top -n2

top - 21:44:59 up  2:23,  1 user,  load average: 0.08, 0.02, 0.00
Tasks: 138 total,   1 running, 137 sleeping,   0 stopped,   0 zombie
%Cpu(s):  0.7 us,  0.3 sy,  0.0 ni, 99.0 id,  0.0 wa,  0.0 hi,  0.0 si,  0.0 st
MiB Mem :   1995.4 total,    172.6 free,   1045.0 used,    777.8 buff/cache
MiB Swap:   2046.0 total,   2040.5 free,      5.5 used.    728.0 avail Mem 

  PID USER      PR  NI    VIRT    RES    SHR S  %CPU  %MEM     TIME+ COMMAND    
  863 threedp   20   0 2562160 250896  98508 S   0.3  12.3   2:11.24 gnome-she+ 
 4555 threedp   20   0 2859656 266536 128600 S   0.3  13.0   0:22.77 firefox-e+ 
    1 root      20   0  169580  10052   7916 S   0.0   0.5   0:01.40 systemd    
    2 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kthreadd   
    3 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_gp     
    4 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 rcu_par_gp 
    6 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 kworker/0+ 
    8 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 mm_percpu+ 
    9 root      20   0       0      0      0 S   0.0   0.0   0:00.13 ksoftirqd+ 
   10 root      20   0       0      0      0 I   0.0   0.0   0:00.45 rcu_sched  
   11 root      20   0       0      0      0 I   0.0   0.0   0:00.00 rcu_bh     
   12 root      rt   0       0      0      0 S   0.0   0.0   0:00.09 migration+ 
   14 root      20   0       0      0      0 S   0.0   0.0   0:00.00 cpuhp/0    
   15 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kdevtmpfs  
   16 root       0 -20       0      0      0 I   0.0   0.0   0:00.00 netns      
   17 root      20   0       0      0      0 S   0.0   0.0   0:00.00 kauditd    
   18 root      20   0       0      0      0 S   0.0   0.0   0:00.00 khungtaskd 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# ps aux
USER       PID %CPU %MEM    VSZ   RSS TTY      STAT START   TIME COMMAND
root         1  0.0  0.4 169580 10052 ?        Ss   19:21   0:01 /sbin/init
root         2  0.0  0.0      0     0 ?        S    19:21   0:00 [kthreadd]
root         3  0.0  0.0      0     0 ?        I<   19:21   0:00 [rcu_gp]
root         4  0.0  0.0      0     0 ?        I<   19:21   0:00 [rcu_par_gp]
root         6  0.0  0.0      0     0 ?        I<   19:21   0:00 [kworker/0:0H-k
root         8  0.0  0.0      0     0 ?        I<   19:21   0:00 [mm_percpu_wq]
root         9  0.0  0.0      0     0 ?        S    19:21   0:00 [ksoftirqd/0]
root        10  0.0  0.0      0     0 ?        I    19:21   0:00 [rcu_sched]
root        11  0.0  0.0      0     0 ?        I    19:21   0:00 [rcu_bh]
root        12  0.0  0.0      0     0 ?        S    19:21   0:00 [migration/0]
root        14  0.0  0.0      0     0 ?        S    19:21   0:00 [cpuhp/0]
root        15  0.0  0.0      0     0 ?        S    19:21   0:00 [kdevtmpfs]
root        16  0.0  0.0      0     0 ?        I<   19:21   0:00 [netns]
root        17  0.0  0.0      0     0 ?        S    19:21   0:00 [kauditd]
root        18  0.0  0.0      0     0 ?        S    19:21   0:00 [khungtaskd]
root        19  0.0  0.0      0     0 ?        S    19:21   0:00 [oom_reaper]
root        20  0.0  0.0      0     0 ?        I<   19:21   0:00 [writeback]
root        21  0.0  0.0      0     0 ?        S    19:21   0:00 [kcompactd0]
root        22  0.0  0.0      0     0 ?        SN   19:21   0:00 [ksmd]
root        23  0.0  0.0      0     0 ?        SN   19:21   0:01 [khugepaged]
root        24  0.0  0.0      0     0 ?        I<   19:21   0:00 [crypto]
root        25  0.0  0.0      0     0 ?        I<   19:21   0:00 [kintegrityd]
root        26  0.0  0.0      0     0 ?        I<   19:21   0:00 [kblockd]
root        27  0.0  0.0      0     0 ?        I<   19:21   0:00 [edac-poller]
root        28  0.0  0.0      0     0 ?        I<   19:21   0:00 [devfreq_wq]
root        29  0.0  0.0      0     0 ?        S    19:21   0:00 [watchdogd]
root        30  0.0  0.0      0     0 ?        S    19:21   0:00 [kswapd0]
root        48  0.0  0.0      0     0 ?        I<   19:21   0:00 [kthrotld]
root        49  0.0  0.0      0     0 ?        I<   19:21   0:00 [ipv6_addrconf]
root        50  0.0  0.0      0     0 ?        I    19:21   0:00 [kworker/u2:1-e
root        59  0.0  0.0      0     0 ?        I<   19:21   0:00 [kstrp]
root       111  0.0  0.0      0     0 ?        I<   19:21   0:00 [ata_sff]
root       113  0.0  0.0      0     0 ?        S    19:21   0:00 [scsi_eh_0]
root       114  0.0  0.0      0     0 ?        I<   19:21   0:00 [scsi_tmf_0]
root       116  0.0  0.0      0     0 ?        S    19:21   0:00 [scsi_eh_1]
root       117  0.0  0.0      0     0 ?        S    19:21   0:00 [scsi_eh_2]
root       119  0.0  0.0      0     0 ?        I<   19:21   0:00 [scsi_tmf_1]
root       120  0.0  0.0      0     0 ?        I<   19:21   0:00 [scsi_tmf_2]
root       122  0.0  0.0      0     0 ?        I    19:21   0:00 [kworker/u2:2-e
root       133  0.0  0.0      0     0 ?        I<   19:21   0:00 [ttm_swap]
root       135  0.0  0.0      0     0 ?        S    19:21   0:00 [irq/18-vmwgfx]
root       160  0.0  0.0      0     0 ?        I<   19:21   0:00 [kworker/0:1H-k
root       162  0.0  0.0      0     0 ?        I    19:21   0:03 [kworker/0:3-ev
root       198  0.0  0.0      0     0 ?        I<   19:21   0:00 [kworker/u3:0]
root       200  0.0  0.0      0     0 ?        S    19:21   0:00 [jbd2/sda1-8]
root       201  0.0  0.0      0     0 ?        I<   19:21   0:00 [ext4-rsv-conve
root       236  0.0  0.4  33188  9452 ?        Ss   19:21   0:00 /lib/systemd/sy
root       263  0.0  0.2  23232  5452 ?        Ss   19:21   0:00 /lib/systemd/sy
systemd+   271  0.0  0.3  95232  6548 ?        Ssl  19:21   0:00 /lib/systemd/sy
root       411  0.0  0.3  19532  7180 ?        Ss   19:21   0:00 /lib/systemd/sy
root       412  0.0  0.5 398548 11196 ?        Ssl  19:21   0:00 /usr/lib/udisks
root       414  0.0  0.3 238624  6316 ?        Ssl  19:21   0:00 /usr/lib/accoun
root       415  0.0  0.1   8504  2592 ?        Ss   19:21   0:00 /usr/sbin/cron 
avahi      416  0.0  0.1   8284  3196 ?        Ss   19:21   0:00 avahi-daemon: r
root       419  0.0  0.4 318240  9284 ?        Ssl  19:21   0:00 /usr/sbin/Modem
root       421  0.0  0.1 225824  3800 ?        Ssl  19:21   0:00 /usr/sbin/rsysl
message+   423  0.0  0.2  10524  5136 ?        Ss   19:21   0:01 /usr/bin/dbus-d
root       424  0.0  0.2  19768  5108 ?        Ss   19:21   0:00 /sbin/wpa_suppl
root       425  0.0  0.6 332684 13452 ?        Ssl  19:21   0:00 /usr/sbin/Netwo
root       428  0.0  0.2  31448  5088 ?        SNs  19:21   0:00 /usr/sbin/alsac
avahi      454  0.0  0.0   8156   320 ?        S    19:21   0:00 avahi-daemon: c
root       456  0.0  0.9 125820 18632 ?        Ssl  19:21   0:00 /usr/bin/python
root       459  0.0  0.4 185188  8356 ?        Ssl  19:21   0:00 /usr/sbin/cups-
root       463  0.0  0.4 238184  8316 ?        Ssl  19:21   0:00 /usr/lib/policy
root       473  0.0  0.2  29204  5252 ?        Ss   19:21   0:00 /usr/sbin/cupsd
root       476  0.0  0.3 244032  7224 ?        Ssl  19:21   0:00 /usr/sbin/gdm3
root       514  0.0  0.2   9488  5952 ?        S    19:21   0:00 /sbin/dhclient 
rtkit      678  0.0  0.1 152648  2564 ?        SNsl 19:21   0:00 /usr/lib/rtkit/
root       687  0.0  0.3 258476  7620 ?        Ssl  19:22   0:00 /usr/lib/upower
colord     780  0.0  0.5 249136 11588 ?        Ssl  19:22   0:00 /usr/lib/colord
root       807  0.0  0.4 316480  8540 ?        Sl   19:22   0:00 gdm-session-wor
threedp    811  0.0  0.4  21392  9288 ?        Ss   19:22   0:00 /lib/systemd/sy
threedp    812  0.0  0.1 105344  2244 ?        S    19:22   0:00 (sd-pam)
threedp    824  0.0  0.3 240536  6480 ?        Sl   19:22   0:00 /usr/bin/gnome-
threedp    828  0.0  0.2 162152  4728 tty2     Ssl+ 19:22   0:00 /usr/lib/gdm3/g
threedp    830  0.0  0.2  10316  5132 ?        Ss   19:22   0:03 /usr/bin/dbus-d
threedp    832  0.0  0.7 500220 15656 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    863  1.5 12.2 2566384 250976 tty2   Rl+  19:22   2:13 /usr/bin/gnome-
threedp    871  0.0  0.3 313844  6628 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    876  0.0  0.2 381444  5736 ?        Sl   19:22   0:00 /usr/lib/gvfs/g
threedp    878  0.0  2.5 130792 52796 tty2     S+   19:22   0:01 /usr/bin/Xwayla
threedp    891  0.0  0.2 312600  6020 ?        Ssl  19:22   0:00 /usr/lib/at-spi
threedp    896  0.0  0.1   9108  3704 ?        S    19:22   0:00 /usr/bin/dbus-d
threedp    898  0.0  0.3 174128  6684 ?        Sl   19:22   0:00 /usr/lib/at-spi
threedp    901  0.0  1.2 1174124 24600 ?       S<sl 19:22   0:00 /usr/bin/pulsea
threedp    909  0.0  0.8 517204 16880 ?        Sl   19:22   0:00 /usr/lib/gnome-
threedp    913  0.0  1.0 697584 22048 ?        Ssl  19:22   0:00 /usr/lib/evolut
threedp    918  0.0  0.2 159340  4840 ?        Sl   19:22   0:00 /usr/lib/dconf/
threedp    921  0.0  0.4 280348  8948 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    928  0.0  1.4 556344 30340 ?        Sl   19:22   0:00 /usr/lib/gnome-
threedp    929  0.0  0.2 319052  5824 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    934  0.0  0.2 238212  5596 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    938  0.0  0.2 236380  5548 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    949  0.0  0.3 315068  6684 ?        Sl   19:22   0:00 /usr/lib/gnome-
threedp    951  0.0  0.3 240692  6380 ?        Ssl  19:22   0:00 /usr/lib/gvfs/g
threedp    959  0.0  2.4 441296 49064 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    960  0.0  0.4 250524  8188 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    962  0.0  0.2 385048  5684 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    963  0.0  0.2 237572  5544 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    965  0.0  0.3 394752  7184 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    976  0.0  2.3 438572 47992 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    977  0.0  0.3 389388  7804 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    980  0.0  0.3 264376  7920 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    981  0.0  2.3 367116 48268 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    985  0.0  0.2 237976  5840 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    986  0.0  2.3 290296 47092 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    992  0.0  2.4 587136 49140 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    993  0.0  0.7 315136 14848 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    994  0.0  0.4 312404  8720 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp    996  0.0  2.3 438060 47856 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp   1001  0.0  1.3 752568 26828 ?        Ssl  19:22   0:00 /usr/lib/evolut
threedp   1002  0.0  2.4 715364 49540 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp   1004  0.0  0.2 237980  5924 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp   1029  0.0  0.5 357988 11392 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp   1057  0.0  1.2 682552 24968 ?        Ssl  19:22   0:00 /usr/lib/evolut
threedp   1085  0.0  0.8 509508 16732 tty2     SNl+ 19:22   0:00 /usr/lib/tracke
threedp   1087  0.4  6.1 4319300 126308 ?      Ssl  19:22   0:39 /usr/lib/tracke
threedp   1088  0.1  1.8 672544 38036 tty2     SNl+ 19:22   0:10 /usr/lib/tracke
threedp   1089  0.0  6.1 778068 126052 tty2    Sl+  19:22   0:03 /usr/bin/gnome-
threedp   1091  0.0  0.2 235108  5000 tty2     Sl+  19:22   0:00 /usr/lib/gnome-
threedp   1092  0.0  2.7 811884 55260 tty2     Sl+  19:22   0:00 /usr/lib/evolut
threedp   1162  0.0  0.2 164844  5940 ?        Ssl  19:22   0:07 /usr/lib/gvfs/g
root      1169  0.0  0.3 238812  6280 ?        Ssl  19:22   0:00 /usr/lib/bolt/b
threedp   2734  0.0  1.6 477188 33680 ?        SLl  19:26   0:00 /usr/bin/seahor
threedp   2739  0.0  2.1 412668 43724 ?        Ssl  19:26   0:06 /usr/lib/gnome-
threedp   2763  0.0  0.3 314076  6676 ?        Sl   19:26   0:00 /usr/lib/gvfs/g
threedp   2877  0.0  0.3 313840  6868 ?        Sl   19:26   0:00 /usr/lib/gvfs/g
threedp   2891  0.0  0.1   7648  3948 pts/0    Ss   19:26   0:00 bash
root      4155  0.0  0.1   9820  3116 pts/0    S    19:45   0:00 su -
root      4156  0.0  0.1   7752  4080 pts/0    S    19:45   0:00 -bash
threedp   4555  0.5 13.1 2859656 267904 tty2   Sl+  20:41   0:22 /usr/lib/firefo
threedp   4606  0.0  6.7 2438596 137104 tty2   Sl+  20:41   0:01 /usr/lib/firefo
threedp   4668  0.0  4.7 2397788 96252 tty2    Sl+  20:41   0:01 /usr/lib/firefo
threedp   4733  0.3  8.7 2569520 178232 tty2   Sl+  20:41   0:12 /usr/lib/firefo
threedp   4833  0.0  3.5 2383084 72884 tty2    Sl+  20:46   0:00 /usr/lib/firefo
root      4962  0.0  0.0      0     0 ?        I    21:41   0:00 [kworker/0:0-at
root      4978  0.0  0.0      0     0 ?        I    21:46   0:00 [kworker/0:1-at
root      4979  0.0  0.1  10632  3192 pts/0    R+   21:47   0:00 ps aux
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
root@debian:/# 
  
